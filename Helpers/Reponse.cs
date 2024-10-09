using System.Collections.Generic;

namespace WebApi.Helpers
{
    public class Reponse<T>
    {
        private string _error;
        private IEnumerable<T> _data;
        private int _nbreData;
        private T _oneData;
        private bool _connexion;
        private string _categorieUser;


        public bool Connexion
        {
            get { return _connexion; }
            set { _connexion = value; }
        }


        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }


        public IEnumerable<T> Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public int NbreData
        {
            get { return _nbreData; }

            set { _nbreData = value; }
        }


        public string CategorieUser
        {
            get { return _categorieUser; }
            set { _categorieUser = value; } 
        }


        public T OneData
        {
            get { return this._oneData; }
            set { _oneData = value; }
        }


        public Reponse(string error, int nbreData, IEnumerable<T> data, T oneData,bool Connexion)
        {
            _error = error;
            _nbreData = nbreData;
            _data = data;
            _oneData = oneData;
            _connexion = Connexion;
        }


        public Reponse()
        {

        }






    }
}
