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

	public function insert($jsonarray)
	{
		$ip 			= $jsonarray["ip"];
		$isp 			= $jsonarray["isp"];
		$locatie 		= $jsonarray["locatie"];
		$openbittorrent = $jsonarray["openbittorrent"];
		$publicbt		= $jsonarray["publicbt"];
		$istoleit		= $jsonarray["istoleit"];
		$ccc			= $jsonarray["ccc"];
		$demonoid		= $jsonarray["demonoid"];
		$traces			= $jsonarray["traces"];
		$stmt = $this->_db->prepare("INSERT INTO reports(ip,isp,locatie,openbittorrent,publicbt,istoleit,ccc,demonoid,traces,insdate) VALUES(:ip,:isp,:locatie,:openbittorrent,:publicbt,:istoleit,:ccc,:demonoid,:traces,NOW())");
		$stmt->execute(
			array(
				':ip' => $ip,
				':isp' => $isp,
				':locatie' => $locatie,
				':openbittorrent' => $openbittorrent,
				':publicbt' => $publicbt,
				':istoleit' => $istoleit,
				':ccc' => $ccc,
				':demonoid' => $demonoid,
				':traces' => $traces
			)
		);
		return $stmt->rowCount();
	}
}
$json =  json_decode(file_get_contents("php://input"),true);
$api = new TorrentBlockCheck();
echo $api->insert($json);
