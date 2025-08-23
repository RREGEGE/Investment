using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Investment
{
    public class PortfolioManager
    {
        private List<Investment_Model> portfolio;
        
        private const string filePath = "portfolio.json";

        float investmentAmount = 0;
        float currentValue = 0;
        float profitRate = 0;

        public PortfolioManager()
        {
            portfolio = LoadPortfolio();
            InitPortfolio();
        }

        private List<Investment_Model> LoadPortfolio()
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Investment_Model>>(jsonString) ?? new List<Investment_Model>();
            }
            return new List<Investment_Model>();
        }

        private void SavePortfolio()
        {
            var jsonString = JsonSerializer.Serialize(portfolio, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }

        // 매수 금액, 평가 금액, 이익률 초기화
        private void InitPortfolio()
        {
            float _investmentAmount = 0;
            float _currentValue = 0;

            foreach(var _investment in portfolio)
            {
                _investmentAmount += _investment.purchasePrice;
                _currentValue += _investment.currentPrice;
            }

            investmentAmount = _investmentAmount;
            currentValue = _currentValue;
            profitRate = currentValue / investmentAmount;
        }

        // 종목 추가
        public void AddInvestment(Investment_Model investment)
        {
            portfolio.Add(investment);
            SavePortfolio();
            InitPortfolio();
        }

        // 종목 매도 (수량 감소)
        public void SellInvestment(string name, float quantityToSell)
        {
            var investment = portfolio.FirstOrDefault(i => i.name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (investment != null)
            {
                if (investment.quantity > quantityToSell)
                {
                    investment.quantity -= quantityToSell;
                    investment.Init();
                }
                else
                {
                    portfolio.Remove(investment);
                }
                SavePortfolio();
                InitPortfolio();
            }
        }

        // 포트폴리오 조회
        public Dictionary<InvestmentType, List<Investment_Model>> GetGroupedPortfolio()
        {
            return portfolio.GroupBy(i => i.type)
                            .ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}
