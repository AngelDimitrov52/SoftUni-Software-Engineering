using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private List<IAquarium> aquariums;
        public Controller()
        {
            decorationRepository = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }


        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;
            if (aquariumType == nameof(FreshwaterAquarium))
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == nameof(SaltwaterAquarium))
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidAquariumType));
            }
            aquariums.Add(aquarium);

            return (string.Format(OutputMessages.SuccessfullyAdded, aquariumType));
        }




        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;
            if (decorationType == nameof(Ornament))
            {
                decoration = new Ornament();
            }
            else if (decorationType == nameof(Plant))
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidDecorationType));
            }
            decorationRepository.Add(decoration);

            return (string.Format(OutputMessages.SuccessfullyAdded, decorationType));
        }



        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(p => p.Name == aquariumName);

            IFish fish = null;
            if (fishType == nameof(FreshwaterFish))
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);

                if (aquarium.GetType().Name == nameof(FreshwaterAquarium))
                {
                    aquarium.AddFish(fish);
                    return (string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName));
                }
            }
            else if (fishType == nameof(SaltwaterFish))
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);

                if (aquarium.GetType().Name == nameof(SaltwaterAquarium))
                {
                    aquarium.AddFish(fish);
                    return (string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName));
                }
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidFishType));
            }
            return (string.Format(OutputMessages.UnsuitableWater));

        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(p => p.Name == aquariumName);

            decimal decorationPrice = aquarium.Decorations.Sum(p => p.Price);
            decimal fishPrice = aquarium.Fish.Sum(p => p.Price);

            decimal sum = decorationPrice + fishPrice;

            return (string.Format(OutputMessages.AquariumValue, aquariumName, sum));
        }




        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(p => p.Name == aquariumName);

            aquarium.Feed();

            return (string.Format(OutputMessages.FishFed, aquarium.Fish.Count));

        }




        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoration = decorationRepository.FindByType(decorationType);
            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            IAquarium aquarium = aquariums.FirstOrDefault(p => p.Name == aquariumName);

            aquarium.AddDecoration(decoration);
            decorationRepository.Remove(decoration);

            return (string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName));
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
