#region Copyright (c) 2018 WeaselWare Software
/************************************************************************************
'
' Copyright  2018 WeaselWare Software 
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
' Portions Copyright 2018 WeaselWare Software
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
using FrameWorks.Makes.System2110;


namespace FrameWorks.Makes.System2110
{

    public class DrNarwSldr_Mid_LftX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 0.25m;
        const decimal glassReduceX2 = 2.0m * 0.59375m;
        const decimal gasketReduce = 0.629m;


        #endregion

        #region Constructor

        public DrNarwSldr_Mid_LftX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-DrNarwSldr_Mid_LftX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region DoorAlumTB

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5710, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Trim 0.46875 ";
                m_parts.Add(part);

            }

            // StileRight

            ///////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5710, "StileRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Trim 0.46875 ";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5710, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5710, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region StopAlum


            // AlumGlsStop
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5711, "AlumGlsStop", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Vert";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // AlumGlsStop
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5711, "AlumGlsStop", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Horz";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE

            // HDPE_LS_LockEdge
            //for (int i = 0; i < 2; i++)
            //{

            //part = new Part(4266, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
            //part.PartGroupType = "HDPE-Parts";
            //part.PartWidth = part.Source.Width;
            //part.PartThick = part.Source.Height;
            //part.PartLabel = labelStileL = "";

            //m_parts.Add(part);
            //}

            // HDPETop
            //for (int i = 0; i < 2; i++)
            //{

            //part = new Part(5217, "HDPETop", this, 1, m_subAssemblyWidth);
            //part.PartGroupType = "HDPE-Parts";
            //part.PartWidth = part.Source.Width;
            //part.PartThick = part.Source.Height;
            //part.PartLabel = labelStileR = "";

            //m_parts.Add(part);

            //}

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Yellow";

                m_parts.Add(part);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 16; i++)
            {
                part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // PointSetScrew
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "PointSetScrew", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Delivery

            // LS_LeverPull_Set

            //part = new Part(4708, "LS_LeverPull_Set", this, 1, 0.0m);
            //part.PartGroupType = "Delivery-Parts";
            //part.PartLabel = "";

            //m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HookCap

            // EdgeCap

            for (int i = 0; i < 2; i++)
            {
                part = new Part(3623, "EdgeCap", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HookCap-Parts";
                part.PartLabel = "Edge_Cap";

                m_parts.Add(part);

            }

            // HookStrip

            for (int i = 0; i < 2; i++)

            {
                part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
                part.PartGroupType = "HookCap-Parts";
                part.PartWidth = part.Source.Width = 1.3411m;
                part.PartLabel = "CutWidthTo_1.3411";

                m_parts.Add(part);

            }

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //Glass Panel
            part = new Part(5503);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.25m;

            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HardWare Logic

            // CarrageKit

            part = new Part(911, "CarrageKit", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //EPDM_PreSet

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                part = new Part(5713, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                part = new Part(5714, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Edge_Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(1005, "Edge_Seal", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // BotPileKerf+Fin

            for (int i = 0; i < 2; i++)
            {

                part = new Part(5468, "BotPileKerf+Fin", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 2; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght + 0.0625m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////


        }
        #endregion

    }

}