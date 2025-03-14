import { useEffect, useState } from 'react';
import { bowler } from './types/bowler';

function BowlerList() {
  const [bowlers, setBowlers] = useState<bowler[]>([]);

  useEffect(() => {
    const fetchBowler = async () => {
      const response = await fetch('https://localhost:5000/api/BowlingLeague');
      const data = await response.json();

      // Filter only Marlins and Sharks
      const filteredBowlers = data.filter(
        (b: any) => b.teamName === 'Marlins' || b.teamName === 'Sharks'
      );

      setBowlers(filteredBowlers);
    };
    fetchBowler();
  }, []);

  return (
    <>
      <h3>Bowler Info</h3>
      <table>
        <thead>
          <tr>
            <th>Bowler First Name</th>
            <th>Bowler Middle Name</th>
            <th>Bowler Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInitial}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
