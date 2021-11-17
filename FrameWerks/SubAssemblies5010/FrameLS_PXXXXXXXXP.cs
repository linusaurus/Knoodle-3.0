#region Copyright (c) 2016 WeaselWare Software
/************************************************************************************
'
' Copyright  2016 WeaselWare Software 
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
' Portions Copyright 2016 WeaselWare Software
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

namespace FrameWorks.Makes.System5010
{

    public class FrameLS_PXXXXXXXXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 8;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 2.875m;
        const decimal facEndAcc = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX6 = 6.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap3X = 3.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 1.00m;
        const decimal cladRed2X = 1.625m * 2.0m;
        const decimal jambDimW = 1.5m;
        const decimal jambInset = 0.375m;
        const decimal spltHdRed = 6.5275m;
        const decimal faceMidoor = 2.375m;
        const decimal faceXdoor = 4.1525m;
        const decimal pockYtrackAdd = 4.0m;
        const decimal yTrAccess = 2.1525m;
        const decimal notchHDPEadd = 4.0587m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;



        #endregion

        #region Constructor

        public FrameLS_PXXXXXXXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameLS_PXXXXXXXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap3X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region TopTrackUni

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackYPXXXX
            part = new Part(3406, "TopTrackYPXXXX", this, 1, (trackHelper.DoorPanelWidth * 10.0m) - stileOvrLpX6 + pockYtrackAdd + doorGap);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackYPXXX
            part = new Part(3406, "TopTrackYPXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m) - stileOverLap + pockYtrackAdd + yTrAccess);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackYPXX
            part = new Part(3406, "TopTrackYPXX", this, 2, (trackHelper.DoorPanelWidth * 3.0m) - stileOverLap + pockYtrackAdd + yTrAccess);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopTrackYPX
            part = new Part(3406, "TopTrackYPX", this, 2, (trackHelper.DoorPanelWidth * 2.0m) + pockYtrackAdd + yTrAccess);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketGuides

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // PocketGuide
            part = new Part(5151, "WedgePocketGuide", this, 8, 0.0m);
            part.PartGroupType = "PocketGuides";
            part.PartLabel = "";
            part.PartThick = 0.405m;
            part.PartWidth = 1.4715m;
            part.PartLength = 5.0m;
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //OTB_Left
            part = new Part(5425, "OTB_Left", this, 3, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //OTB_Right
            part = new Part(5426, "OTB_Right", this, 3, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            part = new Part(5271, "OTB_Filler", this, 6, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region QuadSeal

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            part = new Part(4910, "QuadSeal", this, 6, 0.0m);
            part.PartGroupType = "QuadSeal";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodClad

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodCladLSJamb -->> 
            part = new Part(4339, "WoodCladLSJamb", this, 2, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "WoodClad";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodCladLSHead ^^
            part = new Part(4339, "WoodCladLSHead", this, 1, m_subAssemblyWidth - cladRed2X);
            part.PartGroupType = "WoodClad";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //BzJambPoc -->> 
            part = new Part(4363, "BzJambPoc", this, 2, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //BzJambPoc -->> 
            part = new Part(4363, "BzJambPoc", this, 2, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadInt ^^
            part = new Part(4364, "FaciaHeadInt", this, 1, m_subAssemblyWidth - jambDimW - jambDimW);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXXXX ^^
            part = new Part(4364, "FaciaHeadExtXXXX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXXX ^^
            part = new Part(4364, "FaciaHeadExtXXX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXX ^^
            part = new Part(4364, "FaciaHeadExtXX", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtX ^^
            part = new Part(4364, "FaciaHeadExtX", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciaCapX ^^
            part = new Part(4364, "FaciaCapX", this, 2, faceCapX);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FaciAccess ^^
            part = new Part(4364, "FaciAccess", this, 2, facEndAcc);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FacEndCap ^^
            part = new Part(4364, "FacEndCap", this, 2, facEndCap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            ///////////////////////////////////////////////////////////////////////////////////////////////

            string notchHDPE = string.Empty;
            decimal[] temp = new decimal[panelCount + 1];

            for (int i = 1; i < panelCount; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            temp[1] = trackHelper.DoorPanelWidth * 2.0m + pockYtrackAdd + notchHDPEadd;
                            notchHDPE = temp[1].ToString() + ",";
                            break;
                        }
                    case 2:
                        {
                            temp[2] = (trackHelper.DoorPanelWidth * 3.0m) - stileOverLap + pockYtrackAdd + notchHDPEadd;
                            notchHDPE += temp[2].ToString() + ",";
                            break;
                        }
                    case 3:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOverLap * 2.0m + pockYtrackAdd + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }
                    default:
                        break;
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;

            // HDPEHead ^^
            part = new Part(3454, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 5.0m) - stileOverLap * 3.0m + pockYtrackAdd + doorGap + headHDPEadd);
            part.PartGroupType = "Frame";
            part.PartLabel = "Notch @ " + notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 8.625m;
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 2, m_subAssemblyHieght - calkGap - reducHDPE);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;            
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}