using System;
using System.Collections;
using System.Linq;

namespace Subnetting_Calculator
{
    class Calculator
    {
        private address initialAddress;
        private int mask;
        private int requestedNumber;
        private String IPClass;

        public Calculator(int first, int second, int third, int fourth, int maskp, int req, String ip)
        {
            this.initialAddress = new address(first, second, third, fourth);
            this.requestedNumber = req;
            this.IPClass = ip;
            this.mask = maskp;
        }

        private string decTobin(int n, int bits)
        {
            String bin = Convert.ToString(n, 2);
            int rBits = bits - bin.Length;
            bin = String.Concat(Enumerable.Repeat("0", rBits)) + bin;
            return bin;
        }

        private int getN(int num)
        {
            int i = 0;
            int res = 0;
            while(res < num)
            {
                res = (Convert.ToInt32(Math.Pow(2, i))) - 2;
                if(res < num)
                {
                    i++;
                }
                else
                {
                    return i;
                }
            }
            return i;
        }

        private int getJumping()
        {
            String binMask = "";
            if(IPClass == "A")
            {
                binMask = String.Concat(Enumerable.Repeat("1", getN(requestedNumber))) +
                          String.Concat(Enumerable.Repeat("0", 24 - getN(requestedNumber)));
                return 16777216 - Convert.ToInt32(binMask, 2);
            }
            else if (IPClass == "B")
            {
                binMask = String.Concat(Enumerable.Repeat("1", getN(requestedNumber))) +
                          String.Concat(Enumerable.Repeat("0", 16 - getN(requestedNumber)));
                return 65536 - Convert.ToInt32(binMask, 2);
            }
            else if (IPClass == "C")
            {
                binMask = String.Concat(Enumerable.Repeat("1", getN(requestedNumber))) +
                          String.Concat(Enumerable.Repeat("0", 8 - getN(requestedNumber)));
                return 256 - Convert.ToInt32(binMask, 2);
            }
            return 0;
        }

        private int getJumpingHosts()
        {
            String binMask = "";
            if (IPClass == "A")
            {
                binMask = String.Concat(Enumerable.Repeat("1", 24 - getN(requestedNumber))) +
                          String.Concat(Enumerable.Repeat("0", getN(requestedNumber)));
                return 16777216 - Convert.ToInt32(binMask, 2);
            }
            else if (IPClass == "B")
            {
                binMask = String.Concat(Enumerable.Repeat("1", 16 - getN(requestedNumber))) +
                          String.Concat(Enumerable.Repeat("0", getN(requestedNumber)));
                return 65536 - Convert.ToInt32(binMask, 2);
            }
            else if (IPClass == "C")
            {
                binMask = String.Concat(Enumerable.Repeat("1", 8 - getN(requestedNumber))) +
                          String.Concat(Enumerable.Repeat("0", getN(requestedNumber)));
                return 256 - Convert.ToInt32(binMask, 2);
            }
            return 0;
        }

        private address setIp(address initial, int add)
        {
            address nAddr = new address(initial.firstOctect, initial.secondOctect, initial.thirdOctect, initial.fourthOctect);
            int bitQuant = 0;
            switch (IPClass)
            {
                case "A":
                    bitQuant = 24;
                    break;
                case "B":
                    bitQuant = 16;
                    break;
                case "C":
                    bitQuant = 8;
                    break;
            }
            String bin = decTobin(add, bitQuant);
            if (add == 0)
            {
                return nAddr;
            }
            else
            {
                if (IPClass == "A")
                {
                    nAddr.secondOctect = Convert.ToInt32(bin.Substring(0, 8), 2);
                    nAddr.thirdOctect = Convert.ToInt32(bin.Substring(8, 8), 2);
                    nAddr.fourthOctect = Convert.ToInt32(bin.Substring(16, 8), 2);
                    return nAddr;
                }
                else if (IPClass == "B")
                {
                    nAddr.thirdOctect = Convert.ToInt32(bin.Substring(0, 8), 2);
                    nAddr.fourthOctect = Convert.ToInt32(bin.Substring(8, 8), 2);
                    return nAddr;
                }
                else if (IPClass == "C")
                {
                    nAddr.fourthOctect = Convert.ToInt32(bin.Substring(0, 8), 2);
                    return nAddr;
                }
            }
            return nAddr;
        }

        private address pointedMask(int mask)
        {
            String binMask = String.Concat(Enumerable.Repeat("1", mask));
            binMask += String.Concat(Enumerable.Repeat("0", 32- mask));

            address nMask = new address(Convert.ToInt32(binMask.Substring(0, 8), 2),
                                        Convert.ToInt32(binMask.Substring(8, 8), 2),
                                        Convert.ToInt32(binMask.Substring(16, 8), 2),
                                        Convert.ToInt32(binMask.Substring(24, 8), 2));
            return nMask;
        }

        public ArrayList calculateBySubNets()
        {
            int newMask = mask + getN(requestedNumber);
            int netJumping = 0;
            ArrayList subnets = new ArrayList();
            address addObj = initialAddress;
            Result resObj;
            for(int i=0; i<requestedNumber;i++)
            {
                resObj = new Result();
                resObj.setNetwork(setIp(addObj, netJumping));
                resObj.setFirst(setIp(addObj, netJumping + 1));

                netJumping += getJumping();

                resObj.setLast(setIp(addObj, netJumping - 2));
                resObj.setBroad(setIp(addObj, netJumping - 1));

                subnets.Add(resObj);
            }
            address pMask = pointedMask(newMask);
            subnets.Add(pMask);
            return subnets;
        }

        public ArrayList calculateByHosts()
        {
            int newMask = 0;
            if (IPClass == "A")
            {
                newMask = mask + (24 - getN(requestedNumber));
            }
            else if (IPClass == "B")
            {
                newMask = mask + (16 - getN(requestedNumber));
            }
            else if (IPClass == "C")
            {
                newMask = mask + (8 - getN(requestedNumber));
            }
            int netJumping = 0;
            ArrayList subnets = new ArrayList();
            address addObj = initialAddress;
            Result resObj;
            resObj = new Result();
            resObj.setNetwork(setIp(addObj, netJumping));
            resObj.setFirst(setIp(addObj, netJumping + 1));

            netJumping += getJumpingHosts();

            resObj.setLast(setIp(addObj, netJumping - 2));
            resObj.setBroad(setIp(addObj, netJumping - 1));

            subnets.Add(resObj);
            address pMask = pointedMask(newMask);
            subnets.Add(pMask);
            return subnets;
        }
    }
}
