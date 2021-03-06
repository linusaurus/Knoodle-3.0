﻿#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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

namespace FrameWorks.Makes.System3000
{
    
    public class SlidingFrameOXX3D3 : SubAssemblyBase
    {


        #region Fields



        #endregion

        #region Constructor

        public SlidingFrameOXX3D3()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "SlidingFrameOXX3D3";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            
            System3000.Helper.SliderOXXHelper helper = new System3000.Helper.SliderOXXHelper(3, 3, m_subAssemblyWidth);



            #region Frame



            // TopTrack
            part = new Part(1416, "TopTrack", this, 1, m_subAssemblyWidth );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // HeadHanger
            part = new Part(2096, "HeadHanger", this, 2, m_subAssemblyWidth );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // SplitHead
            part = new Part(810, "SplitHead", this, 2, m_subAssemblyWidth - 0.4375m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // StrikeJamb 
            part = new Part(2304, "StrikeJamb", this, 1, m_subAssemblyHieght + 2.901m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // JambHanger 
            part = new Part(2098, "JambHanger", this, 2, m_subAssemblyHieght + 2.901m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // SplitJamb
            part = new Part(810, "SplitJamb", this, 2, m_subAssemblyHieght );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // PVC EndCapHanger
            part = new Part(2319, "EndCapHanger", this, 1, 0.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // EndCap
            part = new Part(2324, "EndCap", this, 1, 0.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region Access Panel



            // AccessSupport
            part = new Part(2398, "AccessSupport", this, 2, 0.0m);
            part.PartGroupType = "Access-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // CoverPlate
            part = new Part(2398, "CoverPlate", this, 1, 0.0m);
            part.PartGroupType = "Access-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Slot Drain



            // SlotDrain
            part = new Part(215, "SlotDrain", this, 1, m_subAssemblyWidth + 1.0625m + 1.1875m );
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // DrainCaps
            part = new Part(2328, "DrainCaps", this, 2, 0.0m);
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // DrainBlocks
            part = new Part(2085, "DrainBlocks", this, 2, 0.0m);
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);





            #endregion

            #region Pile Seals


            // PileSH
            part = new Part(978, "PileSH", this, 2, m_subAssemblyWidth - 0.4375m );
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // PileSJ 
            part = new Part(978, "PileSJ", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // PileSD
            part = new Part(978, "PileSD", this, 2, m_subAssemblyWidth + 1.0625m + 1.1875m);
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // PileEC
            part = new Part(978, "EndCapPile", this, 1, 3.125m);
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);






            #endregion

            #region Hardware


            // CornerBrace
            part = new Part(2313, "CornerBrace", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // BHScrews
            part = new Part(1439, "BHScrews", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region Labor 

            part = new LPart("MetalHours",this, 9.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish

            #endregion


        }

        #endregion

    }
}

