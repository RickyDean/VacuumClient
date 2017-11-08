namespace IntelligentVacuum.Agent
{
    using System;
    using System.Collections.Generic;
    using Environments;

    public class Agent
    {
        public Agent()
        {
            //This is not working right, but was an effort.
            int x = room.XAxis;
            int y = room.YAxis;
            AgentAction.action;
            // Sense
            bool isDirty = room.IsDirty;
            //Plan
            if(isDirty)
            {
                 action = AgentAction.CLEAN;
            }
            else
            {
                for (y = 1; y< room.YAxis; y--)
                {
                    if (x < room.XAxis)
                    {
                        action = AgentAction.MOVE_RIGHT;
                    }
                    else
                        {
                        action = AgentAction.MOVE_DOWN
                    }
                    return action;
        }

        //public AgentAction DecideAction(Room room)
        //{
           // return AgentAction.NONE;
        //}
    }
}
