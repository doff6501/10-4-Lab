using System;
using System.Collections.Generic;
using System.Text;

namespace _10_4_lab
{
    class MediaPlayer
    {

        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}