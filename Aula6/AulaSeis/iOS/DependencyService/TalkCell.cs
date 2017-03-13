using System;
using AulaSeis.DependencyServices;
using AulaSeis.iOS.DependencyService;
using AVFoundation;

[assembly: Xamarin.Forms.Dependency(typeof(TalkCell))]
namespace AulaSeis.iOS.DependencyService
{
    public class TalkCell : ITalkCell
    {
        public TalkCell()
        {
        }

        public void TextToTalk(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("pt-BR"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
