#region Copyright (c) 2020 WeaselWare Software
/************************************************************************************
'
' Copyright  2020 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2020 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System1140
{

    public class FrameSliderPXXXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 4;
        const decimal stileHalfLap = 1.1875m / 2.0m;
        const decimal stileOverLap = 1.1875m;
        const decimal stileOvrLpX2 = 2.0m * 1.1875m;
        const decimal stileOvrLpX3 = 3.0m * 1.1875m;
        const decimal jambAdd = 1.285m;
        const decimal jambWide = 1.535m;
        const decimal doorGap = 0.25m;
        const decimal jambRed = 2.625m;
        const decimal jambInset = 0.25m;
        const decimal faceMidoor = 2.66m;
        const decimal notchHDPEadd = 4.375m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEaddPoc = 4.5m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAddPocket = 3.75m;
        const decimal trackAddOvTrav = 2.5m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameSliderPXXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System1140-FrameSliderPXXXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambAdd ,0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FloorTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FASTrackPXXXX
            part = new Part(3444, "FASTrackPXXXX", this, 1, trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3 - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FASTrackPXXX
            part = new Part(3444, "FASTrackPXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX2) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FASTrackPXX
            part = new Part(3444, "FASTrackPXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m - stileOverLap) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FASTrackPX
            part = new Part(3444, "FASTrackPX", this, 1, (trackHelper.DoorPanelWidth * 2.0m ) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // GutterPXXXX
            part = new Part(7386, "GutterPXXXX", this, 1, trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3 - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // GutterPXXXX
            part = new Part(7386, "GutterPXXXX", this, 1, trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3 - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // GutterPXXX
            part = new Part(7386, "GutterPXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX2) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // GutterPXXX
            part = new Part(7386, "GutterPXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX2) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // GutterPXX
            part = new Part(7386, "GutterPXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m - stileOverLap) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // GutterPXX
            part = new Part(7386, "GutterPXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m - stileOverLap) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // GutterPX
            part = new Part(7386, "GutterPX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // GutterPX
            part = new Part(7386, "GutterPX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - doorGap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HeadAngle

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAnglePXXXX
            part = new Part(3629, "TopAnglePXXXX", this, 1, trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3 - doorGap + trackAddPocket);
            part.PartGroupType = "HeadAngleL4";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            //TopAnglePXXXX
            part = new Part(3629, "TopAnglePXXXX", this, 1, trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3 - doorGap + trackAddPocket);
            part.PartGroupType = "HeadAngleL4";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAnglePXXX
            part = new Part(3629, "TopAnglePXXX", this, 1, trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX2 - doorGap + trackAddPocket + headHDPEaddPoc);
            part.PartGroupType = "HeadAngleL4";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAnglePXX
            part = new Part(3629, "TopAnglePXX", this, 1, trackHelper.DoorPanelWidth * 3.0m - stileOverLap - doorGap + trackAddPocket + headHDPEaddPoc);
            part.PartGroupType = "HeadAngleL4";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAnglePX
            part = new Part(3629, "TopAnglePX", this, 1, trackHelper.DoorPanelWidth * 2.0m  - doorGap + trackAddPocket + headHDPEaddPoc);
            part.PartGroupType = "HeadAngleL4";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316SSClad

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 316SSCladPXXXX
            part = new Part(911, "316SSCladPXXXX", this, 2, trackHelper.DoorPanelWidth * 4.0m + jambWide);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "3";
            part.PartWidth = 1.0m;
            part.PartThick = 0.16m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // CladSS316
            part = new Part(911, "CladSS316SpltJamb", this, 2, m_subAssemblyHieght - jambRed - calkGap);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "3";
            part.PartWidth = 1.0m;
            part.PartThick = 0.16m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketJambs

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // JambsPocket
            part = new Part(3040, "JambsPocket", this, 2, m_subAssemblyHieght - jambRed - calkGap);
            part.PartGroupType = "PocketJambs";
            part.PartLabel = "";
            part.PartWidth = 1.5m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketCloseOut

            //AlumBar
            part = new Part(2556, "AlumBar", this, 6, 0.0m);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.25m;
            part.PartWidth = 3.0m;
            part.PartLength = 7.00m;
            part.PartLabel = "PXXX";
            m_parts.Add(part);

            //Extira_Closeout
            part = new Part(3210, "Extira_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 7.00m;
            part.PartLabel = "PXXXX";
            m_parts.Add(part);

            //316SS20gaCloseout
            part = new Part(4796, "316SS20gaCloseout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.063m;
            part.PartWidth = 7.00m;
            part.PartLabel = "PXXXX";
            m_parts.Add(part);


            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            string notchHDPE = string.Empty;
            decimal[] temp = new decimal[panelCount + 1];

            for (int i = 1; i < panelCount; i++)
            {

                switch (i)
                {
                    case 1:
                        {
                            temp[1] = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;
                            notchHDPE = temp[1].ToString() + ",";
                            break;
                        }
                    case 2:
                        {
                            temp[2] = (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[2].ToString() + ",";
                            break;
                        }
                    case 3:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }

                    case 4:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOvrLpX3 + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }


                    default:
                        break;
                }

            }

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3) - doorGap + headHDPEaddPoc);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 7.125m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}