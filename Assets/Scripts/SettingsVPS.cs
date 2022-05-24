using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARVRLab.VPSService
{
    public class SettingsVPS
    {
        // Server url
        public string Url = "";
        // Localization delay between sending
        public float localizationTimeout = 1;
        // Calibration delay between sending
        public float calibrationTimeout = 2.5f;
        // Fails count to reset session VPS
        public int failsCountToResetSession;

        public SettingsVPS(string buildingUrl, int failsCountToResetSession)
        {
            Url = buildingUrl;
            this.failsCountToResetSession = failsCountToResetSession;
        }
    }
}