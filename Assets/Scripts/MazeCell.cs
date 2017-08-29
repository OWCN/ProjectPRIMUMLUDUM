public class MazeCell {
    private int x;
    private int y;
    private bool N = true;
    private bool E = true;
    private bool S = true;
    private bool W = true;

    public MazeCell(int xPos, int yPos) {
        x = xPos;
        y = yPos;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public bool getNorth() {
        return N;
    }

    public bool getEast() {
        return E;
    }

    public bool getSouth() {
        return S;
    }

    public bool getWest() {
        return W;
    }

    public void setNorth(bool n) {
        N = n;
    }

    public void setEast(bool n) {
        E = n;
    }

    public void setSouth(bool n) {
        S = n;
    }

    public void setWest(bool n) {
        W = n;
    }
}
