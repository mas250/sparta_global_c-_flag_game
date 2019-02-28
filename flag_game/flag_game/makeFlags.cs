using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag_game
{
    class makeFlags
    {
        public Flag[] createFlags()
        {
            Flag uk = new Flag();
            uk.Name = "UK";
            uk.Path = "../../Images/UK.jpg";

            Flag france = new Flag();
            france.Name = "France";
            france.Path = "../../Images/france.jpg";

            Flag japan = new Flag();
            japan.Name = "Japan";
            japan.Path = "../../Images/japan.jpg";

            Flag china = new Flag();
            china.Name = "China";
            china.Path = "../../Images/china.jpg";

            Flag afghanistan = new Flag();
            afghanistan.Name = "Afghanistan";
            afghanistan.Path = "../../Images/afghanistan.jpg";

            Flag antigua = new Flag();
            antigua.Name = "Antigua";
            antigua.Path = "../../Images/antigua.jpg";

            Flag argentina = new Flag();
            argentina.Name = "Argentina";
            argentina.Path = "../../Images/argentina.jpg";

            Flag armenia = new Flag();
            armenia.Name = "Armenia";
            armenia.Path = "../../Images/armenia.jpg";

            Flag angola = new Flag();
            angola.Name = "Angola";
            angola.Path = "../../Images/angola.jpg";

            Flag australia = new Flag();
            australia.Name = "Australia";
            australia.Path = "../../Images/australia.jpg";

            Flag austria = new Flag();
            austria.Name = "Austria";
            austria.Path = "../../Images/austria.jpg";

            Flag azerbaijan = new Flag();
            azerbaijan.Name = "Azerbaijan";
            azerbaijan.Path = "../../Images/azerbaijan.jpg";

            Flag bahamas = new Flag();
            bahamas.Name = "Bahamas";
            bahamas.Path = "../../Images/bahamas.jpg";

            Flag bahrain = new Flag();
            bahrain.Name = "Baharin";
            bahrain.Path = "../../Images/bahrain.jpg";

            Flag bangladesh = new Flag();
            bangladesh.Name = "Bangladesh";
            bangladesh.Path = "../../Images/bangladesh.jpg";

            Flag barbados = new Flag();
            barbados.Name = "Barbados";
            barbados.Path = "../../Images/barbados.jpg";

            Flag belarus = new Flag();
            belarus.Name = "Belarus";
            belarus.Path = "../../Images/belarus.jpg";

            Flag belgium = new Flag("Belgum", "../../Images/belgium.jpg");
           // belgium.Name = "Belgium";
           // belgium.Path = "../../Images/belgium.jpg";

            Flag belize = new Flag();
            belize.Name = "Belize";
            belize.Path = "../../Images/belize.jpg";

            Flag benin = new Flag();
            benin.Name = "Benin";
            benin.Path = "../../Images/benin.jpg";

            Flag bhutan = new Flag();
            bhutan.Name = "Bhutan";
            bhutan.Path = "../../Images/bhutan.jpg";

            Flag bolivia = new Flag();
            bolivia.Name = "Bolivia";
            bolivia.Path = "../../Images/bolivia.jpg";

            Flag bosnia = new Flag();
            bosnia.Name = "Bosnia";
            bosnia.Path = "../../Images/bosnia.jpg";

            Flag botswana = new Flag();
            botswana.Name = "Botswana";
            botswana.Path = "../../Images/botswana.jpg";

            Flag brazil = new Flag();
            brazil.Name = "Brazil";
            brazil.Path = "../../Images/brazil.jpg";

            Flag brundi = new Flag();
            brundi.Name = "Brundi";
            brundi.Path = "../../Images/brundi.jpg";

            Flag brunei = new Flag();
            brunei.Name = "Brunei";
            brunei.Path = "../../Images/brunei.jpg";

            Flag bulgaria = new Flag();
            bulgaria.Name = "Bulgaria";
            bulgaria.Path = "../../Images/bulgaria.jpg";

            Flag burkina_faso = new Flag();
            burkina_faso.Name = "Burkina Faso";
            burkina_faso.Path = "../../Images/burkina_faso.jpg";

            Flag burma = new Flag();
            burma.Name = "Burma";
            burma.Path = "../../Images/burma.jpg";

            Flag cambodia = new Flag();
            cambodia.Name = "Cambodia";
            cambodia.Path = "../../Images/cambodia.jpg";

            Flag cameroon = new Flag();
            cameroon.Name = "Cameroon";
            cameroon.Path = "../../Images/cameroon.jpg";

            Flag canada = new Flag();
            canada.Name = "Canada";
            canada.Path = "../../Images/canada.jpg";

            Flag cape_verde = new Flag();
            cape_verde.Name = "Cape Verde";
            cape_verde.Path = "../../Images/cape_verde.jpg";

            Flag central_africa = new Flag();
            central_africa.Name = "Central African Republic";
            central_africa.Path = "../../Images/central_african_republic.jpg";

            Flag chad = new Flag();
            chad.Name = "Chad";
            chad.Path = "../../Images/chad.jpg";

            Flag chile = new Flag();
            chile.Name = "Chile";
            chile.Path = "../../Images/chile.jpg";

            Flag colombia = new Flag();
            colombia.Name = "Colombia";
            colombia.Path = "../../Images/colombia.jpg";

            Flag comoros = new Flag();
            comoros.Name = "Comoros";
            comoros.Path = "../../Images/comoros.jpg";

            Flag congo = new Flag();
            congo.Name = "Congo";
            congo.Path = "../../Images/congo.jpg";

            Flag costa_rica = new Flag();
            costa_rica.Name = "Costa Rica";
            costa_rica.Path = "../../Images/costa_rica.jpg";

            Flag croatia = new Flag();
            croatia.Name = "Croatia";
            croatia.Path = "../../Images/croatia.jpg";

            Flag cuba = new Flag();
            cuba.Name = "Cuba";
            cuba.Path = "../../Images/cuba.jpg";



            //add more flags#

            Flag[] allFlags = new Flag[] { uk, france, japan, china, belgium };
            //Flag[] allFlags = new Flag[] { uk, france, japan, china, afghanistan, antigua, argentina,
            //    armenia, angola, australia, austria, azerbaijan, bahamas, bahrain, bangladesh, barbados,
            //    belarus, belgium , belize, benin, bhutan, bolivia, bosnia, botswana, brazil, brundi,
            //    brunei, bulgaria, burkina_faso, burma, cambodia, cameroon, canada, cape_verde, central_africa, chad,
            //    chile, colombia, comoros, congo, costa_rica, croatia, cuba  };
            rand.Randomizer.Randomize(allFlags);

            //place shuffled list in a list of length 4

            return allFlags;
        }
    }
}
