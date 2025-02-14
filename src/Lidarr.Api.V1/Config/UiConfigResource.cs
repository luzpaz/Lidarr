﻿using Lidarr.Http.REST;
using NzbDrone.Core.Configuration;

namespace Lidarr.Api.V1.Config
{
    public class UiConfigResource : RestResource
    {
        //Calendar
        public int FirstDayOfWeek { get; set; }
        public string CalendarWeekColumnHeader { get; set; }

        //Dates
        public string ShortDateFormat { get; set; }
        public string LongDateFormat { get; set; }
        public string TimeFormat { get; set; }
        public bool ShowRelativeDates { get; set; }

        public bool EnableColorImpairedMode { get; set; }
        public int UILanguage { get; set; }

        public bool ExpandAlbumByDefault { get; set; }
        public bool ExpandSingleByDefault { get; set; }
        public bool ExpandEPByDefault { get; set; }
        public bool ExpandBroadcastByDefault { get; set; }
        public bool ExpandOtherByDefault { get; set; }
        public string Theme { get; set; }
    }

    public static class UiConfigResourceMapper
    {
        public static UiConfigResource ToResource(IConfigFileProvider config, IConfigService model)
        {
            return new UiConfigResource
            {
                FirstDayOfWeek = model.FirstDayOfWeek,
                CalendarWeekColumnHeader = model.CalendarWeekColumnHeader,

                ShortDateFormat = model.ShortDateFormat,
                LongDateFormat = model.LongDateFormat,
                TimeFormat = model.TimeFormat,
                ShowRelativeDates = model.ShowRelativeDates,

                EnableColorImpairedMode = model.EnableColorImpairedMode,
                UILanguage = model.UILanguage,

                ExpandAlbumByDefault = model.ExpandAlbumByDefault,
                ExpandSingleByDefault = model.ExpandSingleByDefault,
                ExpandEPByDefault = model.ExpandEPByDefault,
                ExpandBroadcastByDefault = model.ExpandBroadcastByDefault,
                ExpandOtherByDefault = model.ExpandOtherByDefault,
                Theme = config.Theme
            };
        }
    }
}
