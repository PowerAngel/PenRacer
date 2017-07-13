using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private string playerName { get; set; }
    private List<Position> positionHistory;

    public List<Position> getPositionHistory()
    {
        return this.positionHistory;
    }
    public void addPosition(Position newPos)
    {
        positionHistory.Add(newPos);
    }
}
