using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    enum Target
    {
        All,
        PhotoVidio,
        PhotoSong,
        VidioSong,
        Photo,
        Vidio,
        Song
    }
    abstract class BackupOperator
    {
        public abstract void BackUp(Target target);
    }

    class MediaBackUp : BackupOperator
    {
        private Photo photo;
        private Vidio vidio;
        private Song song;
        public MediaBackUp()
        {
            photo = new Photo();
            vidio = new Vidio();
            song = new Song();
        }
        public override void BackUp(Target target)
        {
            switch(target)
            {
                case Target.All:
                    photo.Backup();
                    vidio.Backup();
                    song.Backup();
                    break;
                case Target.Photo:
                    photo.Backup();
                    break;
                case Target.PhotoSong:
                    photo.Backup();
                    song.Backup();
                    break;
                case Target.PhotoVidio:
                    photo.Backup();
                    vidio.Backup();
                    break;
                case Target.Song:
                    song.Backup();
                    break;
                case Target.Vidio:
                    vidio.Backup();
                    break;
                case Target.VidioSong:
                    vidio.Backup();
                    song.Backup();
                    break;
            }
        }
    }
    class FileBackup : BackupOperator
    {
        public override void BackUp(Target target)
        {

        }
    }
}
