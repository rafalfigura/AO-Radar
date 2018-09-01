# AO-Radar

Albion Online Player and Harvestable Radar

# Getting Started

* Download project as source code with git
```
git clone https://github.com/rafalfigura/AO-Radar.git

```
* Launch AlbionRadaro.sln
* Get libs from NuGet
* Update **Photon3DotNet.dll** witch can be found in 
```
game_dir\game\Albion-Online_Data\Managed
```

* Compile and Have Fun

## Features
  [Look at those images](https://imgur.com/a/xRBWGvx)
  
  * Player radar
  * Harvestable radar
  * Map on top of game

  
## Requirements


### WinPcap
This library requires [WinPcap](https://www.winpcap.org/) which comes with [Wireshark](https://www.wireshark.org/).

### Photon
Since it's using Photon you also need to download and link [Photon3DotNet.dll](https://www.photonengine.com/sdks#client-csharp).<br />
Alternatively you can also just link `Photon3Unity3D.dll` if you have a Unity based game.


## Troubleshooting

> System.InvalidOperationException 

Try to reinstall winpcap - thats main reason for that error 
Use [this](https://github.com/PcapDotNet/Pcap.Net/wiki/Using-Pcap.Net-in-your-programs) for setup.

## Albion Online Version

This project is for Albion Online 1.12.365. May not work with other releases.

## Authors

* **_BLU** - *A lot of help with networking * - [0blu](https://github.com/0blu)
* **Rafał Figura** - *Initial work* - [Sahee](https://github.com/rafalfigura)

## Is This Allowed
 ```Our position is quite simple. As long as you just look and analyze we are ok with it. The moment you modify or manipulate something or somehow interfere with our services we will react (e.g. perma-ban, take legal action, whatever```

~MadDave, Technical Lead at Sandbox Interactive for Albion Online, [source](https://forum.albiononline.com/index.php/Thread/51604-Is-it-allowed-to-scan-your-internet-trafic-and-pick-up-logs/?postID=512670#post512670)

* copied from [Albion Online Data](https://www.albion-online-data.com/)
## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Thanks to _BLU for help

## Donations

* *Zcash*	t1W7qHQhLagrrHRVdZQv5mFWdBsGRD92wTp
* *Litecoin*	LcZQaXibdpLaP3iwp5mzju9EMLDpkrGqsc
* *Ethereum*	0x13dc1967492a01d8b8926d3bcd234443984c77c2
