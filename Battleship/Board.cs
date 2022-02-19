namespace Battleship
{
    class Board
    {
        BoardTile[,]? boardTiles;

        private void buildBoardTiles() {
            boardTiles = new BoardTile[10,10];
            for( int x = 0; x < 10; x++ ) {
                for( int y = 0; y < 10; y++ ) {
                    boardTiles[x, y] = new BoardTile();
                }
            }
        }

        public Board() {
            buildBoardTiles();
        }
    }


}