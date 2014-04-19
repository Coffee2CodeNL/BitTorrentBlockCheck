<?php
class TorrentBlockCheck
{
	private $_db;
	public function __construct()
	{
		//Only edit this, nothing else.
		$db_user    = "";
		$db_pass    = "";
		$db_name    = "";
		$db_host    = "";
		try
		{
			$this->_db = new PDO('mysql:host='.$db_host.';dbname='.$db_name.';charset=utf8', $db_user, $db_pass);
		}
		catch(PDOException $e)
		{
			throw new Exception($e->getMessage());
		}

	}

	public function getReports()
	{
		$query 			= "select sum(openbittorrent) as openbittorrent,sum(publicbt) as publicbt,sum(istoleit) as istoleit ,sum(ccc) as ccc ,sum(demonoid) as demonoid from reports where insdate >= DATE_SUB(CURDATE(), INTERVAL 1 MONTH)";
		$stmt 			= $this->_db->prepare($query);
		$obtsum 		= null;
		$publicbtsum 	= null;
		$istoleitsum 	= null;
		$cccsum			= null;
		$demonoidsum	= null;
		if($stmt->execute())
		{
			while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
				$obtsum 		= $row["openbittorrent"];
				$publicbtsum	= $row["publicbt"];
				$istoleitsum	= $row["istoleit"];
				$cccsum			= $row["ccc"];
				$demonoidsum	= $row["demonoid"];
			}

		}
		$query			= "select id from reports";
		$stmt			= $this->_db->prepare($query);
		$totalrows = null;
		if($stmt->execute())
		{
			$totalrows = $stmt->rowCount();
		}
		$query			= "select ip, isp, locatie, insdate, openbittorrent, publicbt, istoleit, ccc, demonoid from reports where insdate >= DATE_SUB(CURDATE(), INTERVAL 1 MONTH) order by insdate desc limit 5";
		$stmt			= $this->_db->prepare($query);
		$rows = null;
		if($stmt->execute())
		{
			while($row = $stmt->fetch(PDO::FETCH_ASSOC))
			{
				$ip			= $row["ip"];
				$ip_segments= explode('.', $ip);
				$ip 		= $ip_segments[0].".".$ip_segments[1].".".$ip_segments[2].".XXX";
				$isp		= $row["isp"];
				$locatie	= $row["locatie"];
				$datum		= $row["insdate"];
				$date 		= new DateTime($datum, new DateTimeZone("Europe/Amsterdam"));
				$datum 		= $date->format('d-m-y H:i:s');
				$obtstatus	= ($row["openbittorrent"] == 1) ? '<i class="fa fa-check-square fa-2x"></i>' : '<i class="fa fa-minus-square fa-2x"></i>';
				$pbtstatus	= ($row["publicbt"]  == 1) ? '<i class="fa fa-check-square fa-2x"></i>' : '<i class="fa fa-minus-square fa-2x"></i>';;
				$isistatus	= ($row["istoleit"]  == 1) ? '<i class="fa fa-check-square fa-2x"></i>' : '<i class="fa fa-minus-square fa-2x"></i>';;
				$cccstatus  = ($row["ccc"]  == 1) ? '<i class="fa fa-check-square fa-2x"></i>' : '<i class="fa fa-minus-square fa-2x"></i>';;
				$dstatus	= ($row["demonoid"]  == 1) ? '<i class="fa fa-check-square fa-2x"></i>' : '<i class="fa fa-minus-square fa-2x"></i>';;
				$rows		.= "<tr><td>".
								$datum.
								"</td><td>".
								$ip.
								"</td><td>".
								$isp.
								"</td><td>".
								$locatie.
								'</td><td class="center">'.
								$obtstatus.
								'</td><td class="center">'.
								$pbtstatus.
								'</td><td class="center">'.
								$isistatus.
								'</td><td class="center">'.
								$cccstatus.
								'</td><td class="center">'.
								$dstatus.
								"</td></tr>";

			}
		}
		$results = array();
		$results["openbittorrent"]["up"] 	= $obtsum;
		$results["openbittorrent"]["down"] 	= $totalrows - $obtsum;
		$results["publicbt"]["up"] 			= $publicbtsum;
		$results["publicbt"]["down"]		= $totalrows - $publicbtsum;
		$results["istoleit"]["up"]			= $istoleitsum;
		$results["istoleit"]["down"]		= $totalrows - $istoleitsum;
		$results["ccc"]["up"]				= $cccsum;
		$results["ccc"]["down"]				= $totalrows - $cccsum;
		$results["demonoid"]["up"]			= $demonoidsum;
		$results["demonoid"]["down"]		= $totalrows - $demonoidsum;
		$results["total"]					= $totalrows;
		$results["rows"]					= $rows;
		return $results;
	}
}
$tbc = new TorrentBlockCheck();
$r = $tbc->getReports();
?>
<!doctype html>
<html>
<head>
	<title>Torrent Tracker Blokkade Check - Stop Downloadverbod #downloadverbod</title>
	<script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
	<script src="//code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
	<link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">
	<link href="css/main.css" rel="stylesheet">
	<link rel="icon" href="favicon.ico" type="image/x-icon"/>
	<link rel="shortcut icon" href="favicon.ico" type="image/x-icon"/>
	<script>
		(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
			(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
			m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
		})(window,document,'script','//www.google-analytics.com/analytics.js','ga');

		ga('create', 'UA-48886258-2', 'dead-pixel.nl');
		ga('send', 'pageview');

	</script>
	<script type="text/javascript">
		$(document).ready(function(){
			$(window).resize(function(){

				$('#container').css({
					position:'absolute',
					left: ($(window).width() - $('#container').outerWidth())/2,
					top: ($(window).height() - $('#container').outerHeight())/2
				});

			});
			// To initially run the function:
			$(window).resize();
		});
	</script>
</head>
<body>
<div id="container">
<div id="header">
<h1 class="center">Torrent Tracker Blokkade Check</h1>
</div>
	<div id="body">
		<div id="tiles">
		<div class="trackertile">
			<div class="tileheader">OpenBitTorrent</div>
			<div class="tilebody"></div>
			<div class="tileup"><i class="fa fa-chevron-up fa-inverse"></i><span class="tilenumber"><?php echo $r["openbittorrent"]["up"]; ?></span></div><div class="tiledown"><i class="fa fa-chevron-down fa-inverse"></i><span class="tilenumber"><?php echo $r["openbittorrent"]["down"]; ?></span></div>
		</div>

		<div class="trackertile">
			<div class="tileheader">PublicBitTorrent</div>
			<div class="tilebody"></div>
			<div class="tileup"><i class="fa fa-chevron-up fa-inverse"></i><span class="tilenumber"><?php echo $r["publicbt"]["up"]; ?></span></div><div class="tiledown"><i class="fa fa-chevron-down fa-inverse"></i><span class="tilenumber"><?php echo $r["publicbt"]["down"]; ?></span></div>
		</div>

		<div class="trackertile">
			<div class="tileheader">iStole.it</div>
			<div class="tilebody"></div>
			<div class="tileup"><i class="fa fa-chevron-up fa-inverse"></i><span class="tilenumber"><?php echo $r["istoleit"]["up"]; ?></span></div><div class="tiledown"><i class="fa fa-chevron-down fa-inverse"></i><span class="tilenumber"><?php echo $r["istoleit"]["down"]; ?></span></div>
		</div>

		<div class="trackertile">
			<div class="tileheader">CCC</div>
			<div class="tilebody"></div>
			<div class="tileup"><i class="fa fa-chevron-up fa-inverse"></i><span class="tilenumber"><?php echo $r["ccc"]["up"]; ?></span></div><div class="tiledown"><i class="fa fa-chevron-down fa-inverse"></i><span class="tilenumber"><?php echo $r["ccc"]["down"]; ?></span></div>
		</div>

		<div class="trackertile lasttile">
			<div class="tileheader">Demonoid</div>
			<div class="tilebody"></div>
			<div class="tileup"><i class="fa fa-chevron-up fa-inverse"></i><span class="tilenumber"><?php echo $r["demonoid"]["up"]; ?></span></div><div class="tiledown"><i class="fa fa-chevron-down fa-inverse"></i><span class="tilenumber"><?php echo $r["demonoid"]["down"]; ?></span></div>
		</div>
		</div>
		<div id="last_reports">
			<h2>Rapporten Ontvangen: <?php echo $r["total"]; ?></h2>
			<em>Dit zijn de laatste 5 ontvangen rapporten.</em>
			<table border="0" width="800px">
				<thead>
					<th>Datum</th><th>IP</th><th>ISP</th><th>Locatie</th><th>OpenBitTorrent</th><th>PublicBitTorrent</th><th>iStole.it</th><th>CCC.de</th><th>Demonoid</th>
				</thead>
				<tbody>
					<?php echo $r["rows"]; ?>
				</tbody>
			</table>
			<br />

		</div>
		<div id="footer">
			<p>Help mee om in de gaten te houden hoe diep de anti-downloadwet gaat, download de applicatie en help mee!</p>
			<p>Je kan ook testen zonder een rapport te verzenden, dit is aan te vinken in de applicatie</p>
			<p>De bovenstaande data is van exact 1 maand, dit tijdsframe is gekozen om de data relevant te houden</p>
			<p>Website & Applicatie &copy; R&eacute; Bassist</p>
		</div>
	</div>
</div>
<div id="download_frame">
<a href="TorrentBlockCheck.exe">
<i class="fa fa-download fa-5x downicon"></i>
DOWNLOAD
</a>
</div>
</body>
</html>
