using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    // interface should always be seeable therefore we only use public
    public interface IDataConnection
    {
        // this is considered as a contract
        // Creates prizes
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        TeamModel CreateTeam(TeamModel model);

        List<PersonModel> GetPerson_All();
    }
}
