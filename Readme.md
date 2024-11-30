# OGMiner

![demo](/imgstore/demo.png)

Utility for calculating the production of planets for the browser game OGame.

## How production is calculated in OGame

- Each planet has a small amount of Natural Production. Resources are produced by natural production, even if there are no mines
- The mines that produce the bulk (base) of the resources are the Metal Mine, Crystal Mine, and Deuterium Synthesizer. All other bonuses are calculated as a percentage of the base production and then simply added together
- Energy is only produced by Solar and Thermonuclear Power Plants and Solar Satellites. All other energy bonuses are calculated as a percentage, similar to mine production
- All other bonuses (crawlers, boosters, officer bonuses, class and alliance bonuses, LF technology bonus) are calculated as a percentage of the base bonus.
- The output from all planets is added up to get the total output of the Empire

Output is affected by:
- Economy speed (server setting)
- Planet temperature (affects deuterium synthesizer performance)
- Planet position (gives additional bonuses affecting the base production of mines and natural production).
