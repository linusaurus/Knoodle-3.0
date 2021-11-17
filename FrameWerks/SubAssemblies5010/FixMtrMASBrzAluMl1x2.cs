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

    public class FixMtrMASBrzAluMl1x2 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduce = .625m;
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal stopRedMiter = 0.1796m;
        const decimal glassReduce = .96875m;
        const decimal glasRedMitWd = .78125m;
        const decimal glasRedMitDp = 2.28125m;
        const decimal glasADDhead = .21875m;
        const decimal centerGapHalf = 0.25m / 2.0m;
        const decimal gasketReduce = 1.0m;
        const decimal coveReduce = 1.5m;



        #endregion

        #region Constructor

        public FixMtrMASBrzAluMl1x2()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FixMtrMASBrzAluMl1x2";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region FrameBrzAlu

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzAluFixVert
            part = new Part(4480, "BrzAluFixVert", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrzAlu";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzAlumFixHorz
            part = new Part(4480, "BrzAlumFixHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrzAlu";
            part.PartLabel = "Miter_90°";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzAlumFixHorz
            part = new Part(4480, "BrzAlumFixHorz", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "FrameBrzAlu";
            part.PartLabel = "Miter_90";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MetalCovers

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //AngleCover
            part = new Part(2799, "AngleCover", this, 1, m_subAssemblyHieght - coveReduce);
            part.PartGroupType = "MetalCovers";
            part.PartLabel = "2-1/2_AngleCover";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //MuntinCover
            part = new Part(1859, "MuntinCover", this, 2, m_subAssemblyHieght - coveReduce);
            part.PartGroupType = "MetalCovers";
            part.PartLabel = "1-1/2_BarCover";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HeadMelcore

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Melcore
            part = new Part(911, "Melcore", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "HeadMelcore";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Melcore
            part = new Part(911, "Melcore", this, 2, m_subAssemblyDepth);
            part.PartGroupType = "HeadMelcore";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // MarinePly
            part = new Part(911, "MarinePly", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HeadMelcore";
            part.PartWidth = 4.75m;
            part.PartThick = 0.75m;
            part.PartLabel = "Head";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // MarinePly
            part = new Part(911, "MarinePly", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "HeadMelcore";
            part.PartWidth = 4.75m;
            part.PartThick = 0.75m;
            part.PartLabel = "Head";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrameInt

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodFixWndVert
            part = new Part(5383, "WoodFixWndVert", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "WoodFrameInt";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodFixWndHorz
            part = new Part(5383, "WoodFixWndHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "WoodFrameInt";
            part.PartLabel = "Miter_90";
            m_parts.Add(part);
 
            /////////////////////////////////////////////////////////////////////////////////////////////// 

            // WoodFixWndHorz
            part = new Part(5383, "WoodFixWndHorz", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "WoodFrameInt";
            part.PartLabel = "Miter_90";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////  

            //WoodCornerCover
            part = new Part(911, "WoodCornerCover", this, 1, m_subAssemblyHieght - coveReduce);
            part.PartGroupType = "WoodFrameInt";
            part.PartLabel = "13/16_Cover";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////// 

            #endregion

            #region StopBrz

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVt
            part = new Part(4298, "BrzGlsStpVt", this, 2, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz  
            part = new Part(4298, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduce - stopRedMiter);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "Miter_90";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz  
            part = new Part(4298, "BrzGlsStpHz", this, 1, m_subAssemblyDepth - stopReduce - stopRedMiter);
            part.PartGroupType = "StopBrz";
            part.PartLabel = "Miter_90";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(4550);
            part.FunctionalName = "GlassCnr";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth / 2.0m - (glasRedMitWd + centerGapHalf);
            part.PartLength = m_subAssemblyHieght - glassReduce + (glasADDhead);
            part.PartThick = 1.230m;
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(4550);
            part.FunctionalName = "GlassJmb";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth / 2.0m - (centerGapHalf + glassReduce) ;
            part.PartLength = m_subAssemblyHieght - glassReduce + glasADDhead;
            part.PartThick = 1.230m;
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(4550);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (glassReduce + glasRedMitDp);
            part.PartLength = m_subAssemblyHieght - glassReduce + glasADDhead;
            part.PartThick = 1.230m;
            part.PartLabel = "TEMPLATE_HEAD";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4265, "BrzCnrBrkt", this, 4, 0.0m);
             part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AluCnrBrkt
            part = new Part(3206, "AluCnrBrkt", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            part = new Part(1545, "SocSetScrw.25_20", this, 32, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //EDPM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
                
                part = new Part(4284, "EDPM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyDepth - gasketReduce);
                
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //EDPM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyDepth - gasketReduce);
                
                part = new Part(4284, "EDPM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}