using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting_Calculator
{
    class Result
    {
        private address network;
        private address firstUsable;
        private address lastUsable;
        private address broadcast;

        public Result()
        {
            this.network = null;
            this.firstUsable = null;
            this.lastUsable = null;
            this.broadcast = null;
        }

        public void setNetwork(address addr)
        {
            this.network = addr;
        }
        public void setFirst(address addr)
        {
            this.firstUsable = addr;
        }
        public void setLast(address addr)
        {
            this.lastUsable = addr;
        }
        public void setBroad(address addr)
        {
            this.broadcast = addr;
        }
        public address getNetwork()
        {
            return this.network;
        }
        public address getFirst()
        {
            return this.firstUsable;
        }
        public address getLast()
        {
            return this.lastUsable;
        }
        public address getBroad()
        {
            return this.broadcast;
        }
    }
}
