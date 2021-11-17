#region Copyright (c) 2019 WeaselWare Software
/************************************************************************************
'
' Copyright  2019 WeaselWare Software 
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
' Portions Copyright 2019 WeaselWare Software
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

namespace FrameWorks.Makes.System2210
{

    public class FrameLS_PXXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal uniTopTrkAddX2 = 2.0m * 3.75m;
        const decimal hdpePoktAddX2 = 2.0m * 4.5m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal JambRedInt = 0.875m;
        const decimal JambRedExt = 0.125m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambDimWX2 = 1.5m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal jambInsetX2 = 2.0m * 0.375m;
        const decimal jambOffsetX2 = 2.0m * 1.125m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_PXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2210-FrameLS_PXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - stileOverLap - jambOffsetX2 - doorGap, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXXP
            part = new Part(3406, "TopTrackPXXP", this, 1, (trackHelper.DoorPanelWidth * 4.0m) + uniTopTrkAddX2 + doorGap2X );
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketGuides

            // PocketGuide
            part = new Part(5151, "WedgePocketGuide", this, 8, 0.0m);
            part.PartGroupType = "PocketGuides";
            part.PartLabel = "";
            part.PartThick = 0.405m;
            part.PartWidth = 1.4715m;
            part.PartLength = 5.0m;
            m_parts.Add(part);

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumPocketSplitJamb -->> 
            part = new Part(4357, "AlumPocketSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //AlumPocketSplitJamb -->> 
            part = new Part(4357, "AlumPocketSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumPocketSplitJamb -->> 
            part = new Part(4357, "AlumPocketSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //AlumPocketSplitJamb -->> 
            part = new Part(4357, "AlumPocketSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadIntXX ^^
            part = new Part(4362, "SplitHeadIntXX", this, 1, m_subAssemblyWidth - jambDimWX2  );
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtXX ^^
            part = new Part(4362, "SplitHeadExtXX", this, 1, m_subAssemblyWidth - jambDimWX2 );
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_T_Slot ^^
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyWidth - jambDimW - jambDimW + jambInsetX2);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

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

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 4.0m) + hdpePoktAddX2 + doorGap - jambInsetX2);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            //for (int i = 0; i < 2; i++)
            //{
            //part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
            //part.PartGroupType = "HDPE_Head";
            //part.PartLabel = "";
            //part.PartThick = 0.75m;
            //part.PartWidth = 2.875m;

            //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}