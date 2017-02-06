using Rabbit.Model;
using Rabbit.View;

namespace Rabbit.Controller
{
    public class MainController
    {
        #region Properties
        protected MainModel _M_ { get; set; } = null;
        public MainModel M
        {
            get
            {
                return _M_;
            }
            set
            {
                if (_M_ == null)
                {
                    _M_ = value;
                }
            }
        }
        protected MainView _V_ { get; set; } = null;
        public MainView V
        {
            get
            {
                return _V_;
            }
            set
            {
                if (_V_ == null)
                {
                    _V_ = value;
                }
            }
        }
        #endregion

        #region Constructor
        public MainController(MainModel m, MainView v)
        {
            M = m;
            V = v;
            V.C = this;
        }

        public MainController(MainView v, MainModel m) : this(m, v)
        {

        }
        #endregion

        #region Methods
        public string[] GetHabits()
        {
            return new string[0];
        }
        #endregion
    }
}
