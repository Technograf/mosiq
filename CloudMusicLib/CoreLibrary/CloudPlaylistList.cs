using CloudMusicLib.ServiceCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMusicLib.CoreLibrary
{
    public class CloudPlaylistList : CloudGenericList<CloudPlaylist>
    {
        public CloudPlaylistList(CloudListMode mode):base(mode)
        { }
        public CloudPlaylistList(CloudListMode mode, Dictionary<string, ServiceResultCollection<CloudPlaylist>> servicesData) 
            : base(mode, servicesData)
        {}
        public void RemoveServicePlaylists(string serviceName)
        {
            _serviceResultData.Remove(serviceName);
            ListData.RemoveAll((CloudPlaylist pl) => pl.ServiceSource.Equals(serviceName));
        }
    }
}
