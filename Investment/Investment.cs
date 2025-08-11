using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment
{
    public enum InvestmentType
    {
        TechETF,
        Stock,
        DividendStock,
        Gold,
        Coin,
        Bond,
        Dollar,
        Won
    }
    public class Investment
    {
        public string name { get; set; }
        public InvestmentType type { get; set; }
        public float quantity { get; set; }
        public float purchasePrice { get; set; }
        public float currentPrice {  get; set; }
        public float meanPurchasePrice { get; set; }

        // 평균 단가 초기화
        public void Init()
        {
            if(quantity > 0)
                meanPurchasePrice = purchasePrice / quantity;
        }
    }
}
