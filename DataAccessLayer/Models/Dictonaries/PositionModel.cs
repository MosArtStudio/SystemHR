using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemHR.DataAccessLayer.Models
{
    public class PositionModel : EntityModel
    {
        public string PositionName { get; set; }
        

        public PositionModel(string positionName)
        {
            PositionName = positionName;
        }
        public override string ToString()
        {
            return PositionName;
        }

    }
}