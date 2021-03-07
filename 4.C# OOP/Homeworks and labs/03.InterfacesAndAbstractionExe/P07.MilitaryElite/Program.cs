using P07.MilitaryElite.Abstractclasses;
using P07.MilitaryElite.Classes;
using System;
using System.Collections.Generic;

namespace P07.MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = comandArgs[0];
                try
                {

                    if (type == nameof(Private))
                    {
                        Soldier privateSoldier =
                           new Private(comandArgs[1], comandArgs[2], comandArgs[3], decimal.Parse(comandArgs[4]));

                        soldiers.Add(privateSoldier);
                    }
                    else if (type == nameof(LieutenantGeneral))
                    {
                        LieutenantGeneral lieutenantGeneral =
                       new LieutenantGeneral(comandArgs[1], comandArgs[2], comandArgs[3], decimal.Parse(comandArgs[4]));

                        for (int i = 5; i < comandArgs.Length; i++)
                        {
                            foreach (var item in soldiers)
                            {
                                if (comandArgs[i] == item.Id)
                                {
                                    lieutenantGeneral.IdsPrivate.Add(((Private)item));
                                }
                            }
                        }

                        soldiers.Add(lieutenantGeneral);
                    }
                    else if (type == nameof(Engineer))
                    {
                        Engineer engineer =
                        new Engineer(comandArgs[1], comandArgs[2], comandArgs[3], decimal.Parse(comandArgs[4]), comandArgs[5]);

                        for (int i = 6; i < comandArgs.Length; i += 2)
                        {
                            Repair repair = new Repair(comandArgs[i], int.Parse(comandArgs[i + 1]));
                            engineer.Repairs.Add(repair);
                        }

                        soldiers.Add(engineer);
                    }
                    else if (type == nameof(Commando))
                    {
                        Commando comando =
                        new Commando(comandArgs[1], comandArgs[2], comandArgs[3], decimal.Parse(comandArgs[4]), comandArgs[5]);

                        for (int i = 6; i < comandArgs.Length; i += 2)
                        {
                            try
                            {

                            Mission missions = new Mission(comandArgs[i], comandArgs[i + 1]);
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                            if (comandArgs[i + 1] == "finished")
                            {
                                continue;
                            }
                            Mission mission = new Mission(comandArgs[i], comandArgs[i + 1]);
                            comando.Missions.Add(mission);
                        }

                        soldiers.Add(comando);
                    }
                    else if (type == nameof(Spy))
                    {
                        Spy spy = new Spy(comandArgs[1], comandArgs[2], comandArgs[3], int.Parse(comandArgs[4]));

                        soldiers.Add(spy);
                    }
                }
                catch (Exception)
                {


                }

            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
