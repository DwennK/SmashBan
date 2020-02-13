using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmashBan.Models;

namespace SmashBan.Services
{
    public class MockDataStore : IDataStore<Stage>
    {
        readonly List<Item> items;
        readonly List<Stage> stages;

        public MockDataStore()
        {
            stages = new List<Stage>()
            {
                new Stage {Nom = "Final Destination", Image="" },
                new Stage {Nom = "Battlefield", Image="" },
                new Stage {Nom = "Smashville", Image="" },
                new Stage {Nom = "Town and City", Image="" },
                new Stage {Nom = "Pokémon Stadium 2", Image="" },
                new Stage {Nom = "Kalos Pokémon League", Image="" }
            };
        }

        public async Task<bool> AddItemAsync(Stage stage)
        {
            stages.Add(stage);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Stage stage)
        {
            var oldItem = stages.Where((Stage arg) => arg.Nom == stage.Nom).FirstOrDefault();
            stages.Remove(oldItem);
            stages.Add(stage);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string Nom)
        {
            var oldItem = stages.Where((Stage arg) => arg.Nom == Nom).FirstOrDefault();
            stages.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Stage> GetItemAsync(string Nom)
        {
            return await Task.FromResult(stages.FirstOrDefault(s => s.Nom == Nom));
        }

        public async Task<IEnumerable<Stage>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(stages);
        }
    }
}