using System;
using Android.Speech.Tts;
using Xamarin.Forms;
using System.Collections.Generic;
using AulaSeis.DependencyServices;
using AulaSeis.Droid.DependencyService;

[assembly: Xamarin.Forms.Dependency(typeof(TalkCell))]
namespace AulaSeis.Droid.DependencyService
{
    public class TalkCell : Java.Lang.Object, ITalkCell, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public TalkCell()
        {
        }

        public void TextToTalk(string text)
        {
            var ctx = Forms.Context; // useful for many Android SDK features
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(ctx, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }
        #endregion
    }
}
