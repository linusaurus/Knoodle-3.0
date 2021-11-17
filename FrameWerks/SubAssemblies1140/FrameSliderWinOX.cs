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

    public class FrameSliderWinOX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal stileHalfLap = 1.1875m / 2.0m;
        const decimal stileOverLap = 1.1875m;
        const decimal stileOvrLpX2 = 2.0m * 1.1875m;
        const decimal stileOvrLpX3 = 3.0m * 1.1875m;
        const decimal jambAdd = 1.285m;
        const decimal jambWide = 1.535m;
        const decimal doorGap = 0.25m;
        const decimal jambRed = 2.625m;
        const decimal jambInset = 0.28125m;
        const decimal jambRedX2 = 1.37875m * 2.0m;
        const decimal notchHDPEadd = 4.375m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEaddPoc = 4.5m;
        const decimal reduceJamb = 1.66m;
        const decimal HDPEJamb = 0.625m;
        const decimal reducHDPE2X = 2.0m * 0.6250m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAdd = 0.3785371m;        
        const decimal trackAddPocket = 3.75m;
        const decimal trackAddOvTrav = 2.5m;
        const decimal overTravel = 4.5m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameSliderWinOX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System1140-FrameSliderWinOX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambRedX2, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FloorTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FASTrack_X
            part = new Part(3444, "FASTrack_X", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap - jambInset);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FASTrackO_
            part = new Part(3444, "FASTrackO_", this, 1, trackHelper.DoorPanelWidth);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "MOD";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Gutter_X
            part = new Part(7386, "Gutter_X", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // Gutter_X
            part = new Part(7386, "Gutter_X", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // GutterO_
            part = new Part(7386, "GutterO_", this, 1, trackHelper.DoorPanelWidth);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            // GutterO_
            part = new Part(7386, "GutterO_", this, 1, trackHelper.DoorPanelWidth);
            part.PartGroupType = "FloorTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HeadAngle

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAngleOX_Int
            part = new Part(3629, "TopAngleOX_Int", this, 1, m_subAssemblyWidth - 2.0m * reduceJamb );
            part.PartGroupType = "HeadAngle";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAngleOX_Mid
            part = new Part(3629, "TopAngleOX_Mid", this, 1, m_subAssemblyWidth - 2.0m * reduceJamb);
            part.PartGroupType = "HeadAngle";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopAngleOX_Ext
            part = new Part(3629, "TopAngleOX_Ext", this, 1, trackHelper.DoorPanelWidth + overTravel - 0.28125m);
            part.PartGroupType = "HeadAngle";
            part.PartLabel = "";
            part.PartWidth = 2.0m;
            part.PartThick = 0.75m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316SSmetal

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 316SSCladHead
            part = new Part(911, "316SSCladHead", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "316SSmetal";
            part.PartLabel = "Head";
            part.PartWidth = 2.0m;
            part.PartThick = 0.375m;
            m_parts.Add(part);

            // 316SSCladJambWide
            part = new Part(911, "316SSCladJamb", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "316SSmetal";
            part.PartLabel = "Wide";
            part.PartWidth = 2.125m;
            part.PartThick = 1.035m;
            m_parts.Add(part);

            // 316SSCladJambNarrow
            part = new Part(911, "316SSCladJamb", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "316SSmetal";
            part.PartLabel = "Narrow";
            part.PartWidth = 2.0m;
            part.PartThick = 0.375m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 316SSCladSill1
            part = new Part(911, "316SSCladSill1", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "316SSmetal";
            part.PartLabel = "Int";
            part.PartWidth = 2.6875m;
            part.PartThick = 0.8125m;
            m_parts.Add(part);

            // 316SSCladSill2
            part = new Part(911, "316SSCladSill2", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "316SSmetal";
            part.PartLabel = "Chanel";
            part.PartWidth = 1.0m;
            part.PartThick = 0.6875m;
            m_parts.Add(part);

            // 316SSCladSill3
            part = new Part(911, "316SSCladSill2", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "316SSmetal";
            part.PartLabel = "Slope";
            part.PartWidth = 2.1875m;
            part.PartThick = 0.8125m;
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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