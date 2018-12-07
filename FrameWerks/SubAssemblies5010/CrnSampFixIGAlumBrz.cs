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

    public class CrnSampFixIGAlumBrz : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;


        #endregion

        #region Constructor

        public CrnSampFixIGAlumBrz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-CrnSampFixIGAlumBrz";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameBrzAlu

            //////////////////////////////////////////////////////////////////////////////

            // BrzAluFixVert
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4321, "BrzAluFixVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzAlumFixHorz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4321, "BrzAlumFixHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrameInt

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndVert
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4330, "WoodFixWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndHorz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4330, "WoodFixWndHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////           

            #endregion

            #region StopAlu

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4327, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpHz  
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4327, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopWdCld

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpVt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4331, "WoodGlsStpVt", this, 1, m_subAssemblyHieght - 2 * stopReduceX2);
                part.PartGroupType = "StopWdCld-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpHz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4331, "WoodGlsStpHz", this, 1, m_subAssemblyWidth - 2 * stopReduceX2);
                part.PartGroupType = "StopWdCld-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PlexiGlass

            //PlexiGlassClear 
            for (int i = 0; i < 20; i++)

            {
                part = new Part(5513);

                part.FunctionalName = "PlexiGlassClear";
                part.PartGroupType = "PlexiGlassClear-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (glassReduce);
                part.PartLength = m_subAssemblyHieght - (glassReduce);
                part.PartThick = 0.1875m;

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BlackWoodSpacerV
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5175, "BlackWoodSpacerV", this, 1, m_subAssemblyHieght - glassReduce);
                part.PartGroupType = "PlexiGlass-Parts";
                part.PartWidth = 0.875m;
                part.PartThick = 0.50m;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BlackWoodSpacerH
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5175, "BlackWoodSpacerH", this, 1, m_subAssemblyWidth - glassReduce);
                part.PartGroupType = "PlexiGlass-Parts";
                part.PartWidth = 0.875m;
                part.PartThick = 0.50m;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            //////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // AluCnrBrkt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(3206, "AluCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 80; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 10; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazPreSetEPDM
                part = new Part(4314, "GlazPreSetEPDM", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazWedgEPDM
                part = new Part(4284, "GlazWedgEPDM", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion



        }


        #endregion


    }
}