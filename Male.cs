using System;

    // abstract class Male {
    //     public abstract void young();
    // }

    interface Male{
        void young();
        int energy {get;set;} // Property can be defined by this way
    }