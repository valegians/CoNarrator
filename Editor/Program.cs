using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using System.Globalization;
using Azure.AI.TextAnalytics;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Text.RegularExpressions;

namespace Editor
{
    static class Program
    {
        private static Analyse analyse = null;
        private static SpeechSynthesis speechSynthesis = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            analyse = new Analyse();
            speechSynthesis = new SpeechSynthesis();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Help()
        {
            MessageBox.Show("" +
                "Markup: \n" +
                "<voice name=\"string\"> </voice>\n" +
                "<mstts:express-as style=\"cheerful\"> </mstts:express-as>\n" +
                "<break strenght=\"none,x-weak,weak,medium,strong,x-strong\"/>\n" +
                "<prosody pitch=\"value\" range=\"value\" rate=\"value\" volume=\"value\"> </prosody>\n\n" +
                "Advanced markup: https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/speech-synthesis-markup?tabs=csharp \n");
        }

        public static Analyse GetAnalyse()
        {
            return analyse;
        }

        public static SpeechSynthesis GetSpeechSynthesis()
        {
            return speechSynthesis;
        }
    }

    class Analyse
    {
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential("key");
        private static readonly Uri endpoint = new Uri("endpoint");

        private readonly TextAnalyticsClient client = null;

        private int passCounter = 1;
        private string lastInput = "";

        public Analyse()
        {
            client = new TextAnalyticsClient(endpoint, credentials);
        }

        public string[] SentimentAnalysisExample(string inputText)
        {
            string analysis = "", markedText = "";
            string[] results = new string[2];

            if(inputText != lastInput)
            {
                passCounter = 1;
                inputText = Regex.Replace(inputText, "<.*?>", String.Empty);
            }
            
            if (passCounter == 1)
            {
                markedText = "<speak version=\"1.0\" xmlns=\"https://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"https://www.w3.org/2001/mstts\" xml:lang=\"en-US\">" +
                "<voice name=\"en-US-AriaNeural\">";

                DocumentSentiment documentSentiment = client.AnalyzeSentiment(inputText);
                analysis += "Document sentiment: " + documentSentiment.Sentiment + "\n";

                //var si = new StringInfo(inputText);
                foreach (var sentence in documentSentiment.Sentences)
                {
                    analysis += "Text: \"" + sentence.Text + "\"\n";
                    analysis += "Sentence sentiment: " + sentence.Sentiment + "\n";
                    analysis += "\tPositive score: " + sentence.ConfidenceScores.Positive + "\n";
                    analysis += "\tNegative score: " + sentence.ConfidenceScores.Negative + "\n";
                    analysis += "\tNeutral score: " + sentence.ConfidenceScores.Neutral + "\n";

                    string caseString = "" + sentence.Sentiment;
                    switch (caseString)
                    {
                        case "Negative":
                            markedText += "<mstts:express-as style=\"newscast\">" + sentence.Text + "</mstts:express-as>";
                            break;
                        case "Positive":
                            markedText += "<mstts:express-as style=\"cheerful\">" + sentence.Text + "</mstts:express-as>";
                            break;
                        default: // Neutral
                            markedText += "<mstts:express-as style=\"chat\">" + sentence.Text + "</mstts:express-as>";
                            break;
                    }
                }

                markedText += "</voice>\n" +
                    "</speak>";

                lastInput = markedText;

                results[0] = markedText; results[1] = analysis;

                passCounter += 1;
                return results;
            }
            else if(passCounter == 2)
            {
                markedText = Regex.Replace(inputText, "</mstts:express-as>", "</prosody></mstts:express-as>");

                markedText = Regex.Replace(markedText, "<mstts:express-as style=\"newscast\">", "<mstts:express-as style=\"newscast\"><prosody rate=\"slow\">");
                markedText = Regex.Replace(markedText, "<mstts:express-as style=\"cheerful\">", "<mstts:express-as style=\"cheerful\"><prosody rate=\"medium\">");
                markedText = Regex.Replace(markedText, "<mstts:express-as style=\"chat\">", "<mstts:express-as style=\"chat\"><prosody rate=\"default\">");

                lastInput = markedText;

                passCounter += 1;
                results[0] = markedText;
                return results;
            }
            else if (passCounter == 3)
            {
                markedText = Regex.Replace(inputText, "<prosody rate=\"slow\">", "<prosody rate=\"slow\" volume=\"soft\">");
                markedText = Regex.Replace(markedText, "<prosody rate=\"medium\">", "<prosody rate=\"medium\" volume=\"medium\">");
                markedText = Regex.Replace(markedText, "<prosody rate=\"default\">", "<prosody rate=\"default\" volume=\"default\">");

                lastInput = markedText;

                passCounter += 1;
                results[0] = markedText;
                return results;
            }
            else
            {
                MessageBox.Show("Analysis complete.");
                results[0] = inputText;
                return results;
            }
        }
    }

    class SpeechSynthesis
    {
        private static readonly string credentials = "key";
        private static readonly string endpoint = "region";

        private SpeechConfig config = null;
        private SpeechSynthesizer synthesizer = null;

        public SpeechSynthesis()
        {
            config = SpeechConfig.FromSubscription(credentials, endpoint);
            synthesizer = new SpeechSynthesizer(config);
        }

        public async void Synthesize(string speech)
        {
            if(speech == "") { return; }

            await synthesizer.SpeakSsmlAsync(speech);
        }

        public async void saveSynthesis(string speech)
        {
            config.SetSpeechSynthesisOutputFormat(SpeechSynthesisOutputFormat.Riff24Khz16BitMonoPcm);
            var synthesizerSave = new SpeechSynthesizer(config, null);

            var result = await synthesizerSave.SpeakSsmlAsync(speech);

            var stream = AudioDataStream.FromResult(result);
            await stream.SaveToWaveFileAsync(@"C:\users\Goofynose\Desktop\audio.wav");
            MessageBox.Show("Saved.");
        }

        public string VoicesInfo()
        {
            string output = "";

            output += "Voices:\t\t\t\n\n";
            output += "en-AU-NatashaNeural\n";
            output += "en-CA-ClaraNeural\n";
            output += "en-GB-LibbyNeural\n";
            output += "en-GB-MiaNeural\n";
            output += "en-US-AriaNeural\n";
            output += "en-US-GuyNeural\n";

            return output;
        }
    }
}
