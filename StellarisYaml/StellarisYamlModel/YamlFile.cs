// ===================================================================================================
//
//      ##########  ###         ##     ##   ## #      #######    ###              ####
//      ##          ##  ##      ##   ##     ##   ##      ##       ##  ##        ##
//      ##          ##     ##   ## ##       ##    ##     ##       ##   ##     ##
//      ##          ##      ##  ###         ##   ##      ##       ##  ##     ##
//      ##########  ##      ##  ###         ## #         ##       ###       ##
//      ##          ##      ##  ## ##       ##           ##       ##  ##     ##
//      ##          ##    ##    ##   ##     ##           ##       ##    ##    ##
//      ##          ##  ##      ##     ##   ##           ##       ##   ##       ##
//      ##          ###         ##       ## ##        #######    ####              ### 
//
//      *Auth:FDKPIBC
//      *CreateDate:2016/5/27 11:20:14
//
// ===================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarisYaml.StellarisYamlModel
{
   public class YamlFile
    {
        public string FileName { get; set; }
        public string Header { get; set; }
        public List<Line> Lines { get; set; }

        public string FullPath { get; set; }
    }
}
