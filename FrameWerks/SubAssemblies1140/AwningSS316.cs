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
using System.Diagnostics;

namespace FrameWorks.Makes.System1140
{

    public class AwningSS316 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal frameReduce2X = 0.875m * 2.0m;
        const decimal gstopReduce2X = 1.59375m * 2.0m;
        const decimal screenReduce2X = 1.512m * 2.0m;
        const decimal gaskFrmReduce = 1.375m;
        const decimal glassReduce2X = 1.59375m * 2.0m;
        const decimal gaskSashReduce = 1.9667m;
        const decimal edgeSealAdd = 0.375m;

        //static int createID;

        #endregion

        #region Constructor

        public AwningSS316()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System1140-AwningSS316";
            this.WrkOrder = new Workorder(this, 1);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            #region Frame316SS

            //////////////////////////////////////////////////////////////////////////////

            // JmbSS316XL <--
            part = new Part(4166, "JmbSS316XL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            // JmbSS316IL <--
            part = new Part(911, "JmbSS316IL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "Angel";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Jmb316SSXR -->
            part = new Part(4166, "Jmb316SSXR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            // Jmb316SSIR -->
            part = new Part(911, "Jmb316SSIR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "Angle";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HeadSS316X ^^
            part = new Part(4166, "HeadSS316X", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            // HeadSS316I ^^
            part = new Part(911, "HeadSS316I", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "Angle";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SillSS316X ||
            part = new Part(4166, "SillSS316X", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "SeeDetail";
            m_parts.Add(part);

            // SillSS316I ||
            part = new Part(911, "SillSS316I", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "Angle";
            m_parts.Add(part);

            // MotorCoverS316 ||
            part = new Part(911, "MotorCoverS316", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame316SS";
            part.PartLabel = "Angle";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region ACTUATOR

            //////////////////////////////////////////////////////////////////////////////////////////////

            // LM/2
            part = new Part(2735, "LM/2", this, 1, 0.0m);
            part.PartGroupType = "ACTUATOR";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
                part = new Part(589, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Sash

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumL <<--
            part = new Part(4086, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileL = "MiterEnds";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumR -->>
            part = new Part(4086, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumT ^^
            part = new Part(4086, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumB ||
            part = new Part(4086, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash";
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316SSClad

            //////////////////////////////////////////////////////////////////////////////

            // 316SSCladXL <--
            part = new Part(4168, "316SSCladXL", this, 1, m_subAssemblyHieght - 0.875m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            // 316SSCladIL <--
            part = new Part(4169, "316SSCladIL", this, 1, m_subAssemblyHieght - 1.375m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // 316SSCladXR -->
            part = new Part(4168, "316SSCladXR", this, 1, m_subAssemblyHieght - 0.875m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            // 316SSCladIR -->
            part = new Part(4169, "316SSCladIR", this, 1, m_subAssemblyHieght - 1.375m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // 316SSCladXT ^^
            part = new Part(4168, "316SSCladXT", this, 1, m_subAssemblyWidth - 0.875m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            // 316SSCladIT ^^
            part = new Part(4169, "316SSCladIT", this, 1, m_subAssemblyWidth - 1.375m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // 316SSCladXB ||
            part = new Part(4168, "316SSCladXB", this, 1, m_subAssemblyWidth - 0.875m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            // 316SSCladIB ||
            part = new Part(4169, "316SSCladIB", this, 1, m_subAssemblyWidth - 1.375m);
            part.PartGroupType = "316SSClad";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            ////////////////////////////////////////////////////////////////////////////////

            // HDPE_HingeBacker
            //part = new Part(5080, "HDPE_HingeBacker", this, 2, 0.0m);
            //part.PartGroupType = "HardWare";
            //part.PartThick = 0.75m;
            //part.PartWidth = 0.5625m;
            //part.PartLength = 9.0m;
            //part.PartLabel = "";
            //m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Hinges
            decimal _wieght = FrameWorks.Functions.PanelWieghtS3000(SubAssemblyWidth, SubAssemblyHieght);
            decimal hingesize = SubAssemblyHieght;
            string id = this.Parent.UnitID.ToString();
            if (_wieght < 250.0m)
            {
                part = new Part(Functions.S3000AwningHinge(hingesize), "Awning Hinge", this, 2, 0.0m);
                part.PartGroupType = "HardWare";
                m_parts.Add(part);
            }
            else
            {
                string message = "The Component is too heavy-" + id.ToString();
                Debug.WriteLine(message);
            }

            int hardwarecount = 1;

            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            // Glass
            part = new Part(4256);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - glassReduce2X);
            part.PartLength = (m_subAssemblyHieght - glassReduce2X);
            part.PartThick = 1.25m;
            part.PartLabel = "PrivaSwitch";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //SashEdgeSeal
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);
                part = new Part(2274, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}