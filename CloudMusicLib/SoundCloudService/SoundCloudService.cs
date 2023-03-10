using System;
using CloudMusicLib.ServiceCore;
using CloudMusicLib.SoundCloudService.SoundCloudMethods;
namespace CloudMusicLib.SoundCloudService
{
     public class SoundCloudService : CloudService
     {
        public string ClientId;
        public string SecretId;
        public SoundCloudService() : base("SoundCloud", false)
         {
            base.Connection = new ScConnection(this);
            base.AddMethod(new ScAuthorizationMethod(this));
            base.AddMethod(new ScInitMethod(this));
            base.AddMethod(new ScGetUserPlaylistMethod(this));
            base.AddMethod(new ScTracksSearch(this));
            base.AddMethod(new ScPlaylistsSearchMethod(this));
            base.RegisterUri = new Uri("https://soundcloud.com/");
            base.RegisterLoginMessage = "Регистрация через профили Google, Facebook\nне поддерживается, регистрируйте прямой SoundCloud\nаккаунт";
            ScApi.Init(this);

         }
    }
}
