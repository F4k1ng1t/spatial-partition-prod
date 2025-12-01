using UnityEngine;
using System.Collections;

namespace SpatialPartitionPattern
{
    //The neutral capsule which runs away from enemies and friendlies
    public class Neutral : Soldier
    {
        //init friendly
        public Neutral(GameObject soldierObj, float mapWidth)
        {
            this.soldierTrans = soldierObj.transform;

            this.walkSpeed = 2f;
        }

        //Move away from the closest guy(TM) im going insane
        public override void Move(Soldier closestFriendly)
        {
            //Rotate towards the closest enemy
            soldierTrans.rotation = Quaternion.LookRotation(-(closestFriendly.soldierTrans.position - soldierTrans.position));
            //Move towards the closest enemy
            soldierTrans.Translate(-(Vector3.forward * Time.deltaTime * walkSpeed));
        }
    }
}