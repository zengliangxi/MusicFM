﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Model;

namespace Service
{
    public interface ISongService 
    {
        List<Song> GetSongList(GetSongParameter parameter);
        ObservableCollection<Channel> GetChannels(bool isBasic = true);
        bool CompletedSong(GetSongParameter parameter);
    }
}
