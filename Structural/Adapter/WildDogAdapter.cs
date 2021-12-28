using Adapter.Dogs;
using Adapter.Lion;

namespace Adapter
{
    public class WildDogAdapter : ILion
    {
        private WildDog mDog;
        public WildDogAdapter(WildDog dog)
        {
            this.mDog = dog;
        }
        public void Roar()
        {
            mDog.bark();
        }
    }
}
