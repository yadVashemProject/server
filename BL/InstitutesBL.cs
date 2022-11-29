using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class InstitutesBL : IinstitutesBL
    {
        IinstitutesDL IinstitutesDL;
        public InstitutesBL(IinstitutesDL IinstitutesDL)
        {
            this.IinstitutesDL = IinstitutesDL;
        }
        public async Task<List<Institutes>> getAllInstitutes()
        {
            var institutes =await IinstitutesDL.getAllInstitutes();
            if (institutes == null)
                return null;
            return institutes;
        }
    }
}
