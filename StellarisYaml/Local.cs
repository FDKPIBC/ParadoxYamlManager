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
//      *CreateDate:2016/5/28 16:23:58
//
// ===================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StellarisYaml.StellarisYamlModel;

namespace StellarisYaml
{
    public class Local
    {
        public static Dictionary<string,string[]> Native { get; set; }
        public static List<YamlFile> YamlFiles { get; set; }
    }
}
