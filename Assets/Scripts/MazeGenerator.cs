using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MazeGenerator : MonoBehaviour {

    enum CellType : int {Normal, Button, Lever, CubeRecptor, Pit, Door, Cube}

	// Use this for initialization
	void Start () {
        createMaze();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public MazeCell[][] createMaze() {
        return arangeSectors(getSectors(6));
    }

    MazeCell[][] arangeSectors(MazeCell[][] sectors) {
        return sectors;
    }

    MazeCell[][] getSectors(int numSectors) {
        MazeCell[][] walls = { };
        return walls;
    }

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

}
