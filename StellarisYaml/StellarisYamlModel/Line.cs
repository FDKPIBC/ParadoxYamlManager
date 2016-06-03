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
//      *CreateDate:2016/5/27 11:21:03
//
// ===================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarisYaml.StellarisYamlModel
{
    public class Line
    {
        public int LineNumber { get; set; }

        public string Tag { get; set; }

        public int Number { get; set; }

        public string Content { get; set; }

        public bool IsChanged { get; set; }

        public Line(string Body)
        {
            try
            {
                Body = Body.Replace("！", "!").Replace("，", ",").Replace("。", ".").Replace("：", ":");
                int index = Body.IndexOf(":");
                Tag = Body.Substring(0, Body.IndexOf(":"));
                Number = int.Parse(Body.Substring(index+1, 1));
                Content = Body.Substring(Body.IndexOf("\"")).Replace("\"","");
                IsChanged = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
