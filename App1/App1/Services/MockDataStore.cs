using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cupom Desconto NETSHOES 50%", Description="Compre qualquer produto com 50% de desconto.", Explanation = "Com o upload da sua carterinha de vacinação aqui no aplicativo da IVacinne, você receberá um cupom de desconto exclusivo, único e intransferível para usar no site da netshoes até 31/10/2021 em qualquer produto disponível no site. Aproveite!!!" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Pague 2, Leve 3", Description="Artigos esportivos na Oscar Calçados", Explanation = "Com o upload da sua carterinha de vacinação aqui no aplicativo da IVacinne, a primeira compra te dará direito a levar 3 artigos esportivos e pagar por apenas 2. Válido por tempo indeterminado." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Plano Premium com 60% de Desconto", Description="Tenha as melhores indicações no mercado de Renda Variável", Explanation = "Com o upload da sua carterinha de vacinação aqui no aplicativo da IVacinne, você receberá um cupom de desconto exclusivo para contar com uma equipe especializada na análise de ações e montar uma carteira diversificada para o seu futuro." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "5 Sessões de Depilação GRÁTIS", Description="Viva um novo mundo com Não Pêlo.", Explanation = "Com o upload da sua carterinha de vacinação aqui no aplicativo da IVacinne, você terá direito a 5 depilações grátis e poderá testar nossos serviços. * A eficácia do tratamento vária de pessoa para pessoa." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chocolates pela metade do preço", Description="Um mundo pós-pandemia, é mundo com mais chocolate.", Explanation = "Com o upload da sua carterinha de vacinação aqui no aplicativo da IVacinne, ao ir em qualquer loja da CacauShow você ganha 50% em compras. * Não válido para datas especiais." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sua idade é porcentagem de desconto", Description="20 anos, 20% de desconto! 50 anos, 50% de desconto.", Explanation = "Com o upload da sua carterinha de vacinação aqui no aplicativo da IVacinne, a primeira compra na Óticas Carol você receberá um cupom de desconto para usar no setor de relojoaria e ótica." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}