using Blog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data
{
    public interface IRemarkHelper
    {
        List<RemarkModel> GetTotalHightestRemarks();
        List<RemarkModel> GetRemarks(int blogID);
        List<RemarkModel> GetHighestRemarks(int blogID);
        void AddRemark(RemarkModel remark);
        void DeleteRemark(RemarkModel remark);
        void Agree(int remarkID);
    }
}
