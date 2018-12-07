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

namespace FrameWorks.Makes.System2010
{

    public class FrameLS_OXXXXO : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 6;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal doorGap3X = 3.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW2X = 1.5m * 2.0m;
        const decimal spltHdAdd = 4.125m;
        const decimal spltheadRed2X = 2.0m * 6.9375m; 
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal hdpeThick = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackReduce = 0.0625m;
        const decimal trackAdd1 = 2.5m;



        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_OXXXXO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameLS_OXXXXO";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap3X - stileOverLap, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackOXXXXO
            part = new Part(3406, "TopTrackOXXXXO", this, 1, m_subAssemblyWidth - jambReduce2X - doorGap2X);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackOX__XO
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3406, "TopTrackOX__XO", this, 1, trackHelper.DoorPanelWidth * 2.0m - trackReduce );
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackO____O
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3406, "TopTrackO____O", this, 1, trackHelper.DoorPanelWidth + trackAdd1 + doorGap);
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            //for (int i = 0; i < 2; i++)
            //{


            //part = new Part(3766, "ShapedYtrackRubber", this, 1, 0.0m);
            //part.PartGroupType = "TopTrackY-Parts";
            //part.PartLabel = "";

            //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Left
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5272, "OTB_Left", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Right
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5216, "OTB_Right", this, 1, 0.0m);
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

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumSpltJambExt -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4357, "AlumSpltJambExt", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //AlumSpltJambInt -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4357, "AlumSpltJambInt", this, 1, m_subAssemblyHieght - hdpeThick - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadIntOXXXXO ^^        
                part = new Part(4362, "SplitHeadIntOXXXXO", this, 1, m_subAssemblyWidth - jambDimW2X);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt__XX__ ^^

            part = new Part(4362, "SplitHeadExt__XX__", this, 1, trackHelper.DoorPanelWidth * 2.0m - spltheadRed2X  + doorGap );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt_X__X_ ^^
            for (int i = 0; i < 2; i++)

            {
                part = new Part(4362, "SplitHeadExt_X__X_", this, 1, trackHelper.DoorPanelWidth - stileOverLap + calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtO____O ^^
            for (int i = 0; i < 2; i++)

            {
                part = new Part(4362, "SplitHeadExtO____O", this, 1, trackHelper.DoorPanelWidth + spltHdAdd);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion


            #region QuadSeal

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4910, "QuadSeal", this, 1, 0.0m);
                part.PartGroupType = "Pile_LS_Seals";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_SealsJambExt -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4384, "Pile_LS_SealsJambExt", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_SealsJambInt -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4384, "Pile_LS_SealsJambInt", this, 1, m_subAssemblyHieght - hdpeThick - calkGap);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealsIntOXXXXO ^^
            part = new Part(4384, "Pile_LS_SealsIntOXXXXO", this, 1, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealsExt__XX__ ^^
            part = new Part(4384, "Pile_LS_SealsExt__XX__", this, 1, trackHelper.DoorPanelWidth * 2.0m - spltheadRed2X + doorGap);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealsExt_X__X_ ^^
            for (int i = 0; i < 2; i++)

            {
                part = new Part(4384, "Pile_LS_SealsExt_X__X_", this, 1, trackHelper.DoorPanelWidth - stileOverLap + calkGap);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealsExtO____O ^^

            for (int i = 0; i < 2; i++)
            {
                part = new Part(4384, "Pile_LS_SealsExtO____O", this, 1, trackHelper.DoorPanelWidth + spltHdAdd);
                part.PartGroupType = "Pile_LS_Seals-Parts";
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
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 4.0m) + jambReduce2X + doorGap2X + doorGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            //for (int i = 0; i < 2; i++)
            //{
            //part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
            //part.PartGroupType = "HDPE_Head-Parts";
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