
#region Copyright (c) 2021 WeaselWare Software
/************************************************************************************
'
' Copyright  2021 WeaselWare Software 
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
' Portions Copyright 2021 WeaselWare Software
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
using FrameWorks.Makes.System2210;


namespace FrameWorks.Makes.System2210
{

    public class DoorCntrPivt : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal glsDrGapX2 = 2.59375m * 2.0m;
        const decimal glsNrwDrGapX2 = 1.0625m * 2.0m;
        const decimal epdmReduce = 2.625m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduceX2 = 2.25m * 2.0m;
        const decimal stopReduceNrwX2 = 0.71875m * 2.0m;


        //

        #endregion

        #region Constructor

        public DoorCntrPivt()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2210-DoorCntrPivt";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region AlumTB3inch

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            part = new Part(5710, "StileLeft|<", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // StileRight
            part = new Part(5710, "StileRight>|", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            part = new Part(4355, "RailTop^", this, 1, m_subAssemblyWidth );
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            part = new Part(4355, "RailBot_", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "AlumTB3inch";
            part.PartLabel = "1) Miter_Ends ";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            ////////////////////////////////////////////////////////////////////////////////

            // HDPELockEdge
            part = new Part(4269, "HDPELockEdge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // HDPEHingEdge
            part = new Part(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPE";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // HDPETop
            part = new Part(4269, "HDPETop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // HDPEBot
            part = new Part(4270, "HDPEBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpLeft <<--
            part = new Part(5711, "AlumGlsStpLeft", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpRight -->>
            part = new Part(5711, "AlumGlsStpRight", this, 1, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTop ^^
            part = new Part(5711, "AlumGlsStpTop", this, 1, m_subAssemblyWidth - stopReduceNrwX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpBot ||
            part = new Part(5711, "AlumGlsStpBot", this, 1, m_subAssemblyWidth - stopReduceNrwX2);
            part.PartGroupType = "StopAlum";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            // GlassPanel
            part = new Part(5785);
            part.FunctionalName = "GlassPanel";
            part.PartGroupType = "Glass-";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glsNrwDrGapX2);
            part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
            part.PartThick = 1.25m;
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region AssyHrdwrDoor

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4830, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            part = new Part(4831, "AlumCnrBrace", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            part = new Part(5180, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // SS_0.7049_OutsetCrnBrace 
            part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 8, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // FlatHead_8-32x3/16_UndercutHead
            part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 32, 0.0m);
            part.PartGroupType = "AssyHrdwrDoor";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC
            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDMglazeDart
                part = new Part(4314, "EPDMglazeDart", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDMglazeWedge
                part = new Part(4284, "EPDMglazeWedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

    }

    #endregion

}

