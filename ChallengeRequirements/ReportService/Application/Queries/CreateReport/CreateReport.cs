

using ReportService.Application.Common;
using ReportService.Infrastructure.GetList;

namespace ReportService.Application.Queries
{
    public class CreateReport : ICreateReport
    {
        private readonly IGetOrderList _getOrder;
        public CreateReport(IGetOrderList getOrder)
        {
            _getOrder = getOrder;
        }

        public async Task<List<ReportModel>> Execute(DateTime from, DateTime to)
        {
            var  data = await _getOrder.Execute(from, to);
            List<ReportModel> res = new List<ReportModel>();
            //Sum of value
            int curStoreID = 0, prvStoreId = 0;
            ReportModel m = null;
            foreach (var i in data.OrderBy(x=>x.StoreId))
            {
                curStoreID = i.StoreId;                
                if (curStoreID != prvStoreId)
                {
                    m = new ReportModel();
                    m.StoreNumber = curStoreID;
                    m.OrderTotalPrice = i.OrderPrice;
                    res.Add(m);
                }
                else
                {
                    if(m!=null)
                        m.OrderTotalPrice += i.OrderPrice;
                }                                
                prvStoreId= curStoreID;
            }

            return res;
        }       
    }
}

