#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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

    public class FrameLS_PXXXXXXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 6;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 2.875m;
        const decimal facEndAcc = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX4 = 4.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap3X = 3.0m * 0.25m;
        const decimal jambReduce = 0.875m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambDimW2X = 1.5m * 2.0m;
        const decimal cladRed2X = 1.625m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal jambInset2X = 2.0m * 0.375m;
        const decimal spltHdRed = 6.9375m;
        const decimal spltHdRed2X = 2.0m * 6.9375m;
        const decimal faceMidoor = 2.4375m;
        const decimal faceXdoor = 4.5m;
        const decimal pockYtrackAdd = 4.0m;
        const decimal pockYtrackAdd2X = 2.0m * 4.0m;
        const decimal yTrAccess = 2.1525m;
        const decimal notchHDPEadd = 4.375m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAdd1 = 6.5m;
        const decimal trackAdd2 = 8.0m;



        #endregion

        #region Constructor

        public FrameLS_PXXXXXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameLS_PXXXXXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - stileOverLap - jambReduce2X - doorGap3X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXXXXXXP
            part = new Part(3406, "TopTrackPXXXXXXP", this, 1, m_subAssemblyWidth + (trackHelper.DoorPanelWidth * 2.0m) - jambDimW2X + trackAdd2);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {

                //TopTrackPXX__XXP
                part = new Part(3406, "TopTrackPXX__XXP", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOverLap - jambInset + trackAdd1 ) ;
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {

                // TopTrackPX____XP
                part = new Part(3406, "TopTrackPX____XP", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - jambInset + trackAdd1);
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketGuides


            // PocketGuide
            for (int i = 0; i < 8; i++)
            {
                part = new Part(5151, "WedgePocketGuide", this, 1, 0.0m);
                part.PartGroupType = "PocketGuides";
                part.PartLabel = "";
                part.PartThick = 0.405m;
                part.PartWidth = 1.4715m;
                part.PartLength = 5.0m;

                m_parts.Add(part);
            }

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Left
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5425, "OTB_Left", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Right
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5426, "OTB_Right", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5271, "OTB_Filler", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region QuadSeal

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4910, "QuadSeal", this, 1, 0.0m);
                part.PartGroupType = "QuadSeal";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //SplitJmbBrz_PXXXXXXP -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4363, "SplitJmbBrz_PXXXXXXP", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //SplitJmbAl_PXXXXXXP -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4357, "SplitJmbAl_PXXXXXXP", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt_P__XX__P ^^
            part = new Part(4364, "SplitHeadExt_P__XX__P", this, 1, (trackHelper.DoorPanelWidth * 2.0m + doorGap) - spltHdRed2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt_P_X__X_P ^^
            for (int i = 0; i < 2; i++)

            {
                part = new Part(4364, "SplitHeadExt_P_X__X_P", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt_PX____XP ^^
            for (int i = 0; i < 2; i++)

            {
                part = new Part(4364, "SplitHeadExt_PX____XP", this, 1, (trackHelper.DoorPanelWidth) - jambInset + faceXdoor);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadIntAlm_PXXXXXXP ^^
            part = new Part(4362, "SplitHeadIntAlm_PXXXXXXP", this, 1, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region WoodClad

            ////////////////////////////////////////////////////////////////////////////////

            // WoodCladLSJamb -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4339, "WoodCladLSJamb", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "WoodClad-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////

            // WoodCladLSHead ^^
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4339, "WoodCladLSHead", this, 1, m_subAssemblyWidth - cladRed2X);
                part.PartGroupType = "WoodClad-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

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

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;


            // HDPEHead ^^
            part = new Part(3454, "HDPE_Head", this, 1, (m_subAssemblyWidth - jambDimW2X + ( trackHelper.DoorPanelWidth * 2.0m ) + pockYtrackAdd2X ));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Notch @ " + notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 8.625m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            //for (int i = 0; i < 2; i++)
            //{
                //part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                //part.PartGroupType = "HDPE_Head-Parts";
                //part.PartLabel = "";
                //part.PartThick = 0.75m;


                //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////



            #endregion


        }


        #endregion

    }


}