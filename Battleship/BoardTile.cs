namespace Battleship
{
    class BoardTile
    {
        Boolean hit;
        Boolean miss;

        public BoardTile() {
            hit = false;
            miss = false;
        }

        public Boolean isUnused() {
            return (!hit && !miss);
        }

        public Boolean isHit() {
            return hit;
        }

        public Boolean isMiss() {
            return miss;
        }

        public void setHit() {
            if( isUnused() ) {
                hit = true;
            }
        }

        public void setMiss() {
            if( isUnused() ) {
                miss = true;
            }
        }

        public override string ToString() {
            if( isHit() ) {
                return "X";
            } else if( isMiss() ) {
                return "+";
            }
            return " ";
        }
    }


}