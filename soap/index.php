<?php

require_once("lib/nusoap.php");
$server = new soap_server();
$service_name="mySOAP";
$namespace='127.0.0.1';
$server->configureWSDL($service_name, $namespace);
$server->wsdl->schemaTargetNamespace = $namespace;
$server->register("dodajKsiazke"
                 ,array('Nazwa'=>'xsd:string', 'Autor'=>'xsd:string', 'Kategoria'=>'xsd:string', 'Lektura'=>'xsd:string')
                 ,array('return'=>'xsd:string')
                 ,$namespace
                 ,false
                 ,'rpc'
                 ,'literal'
                 ,'Metoda dodajaca ksiazke do bazy danych'
                  );

$server->soap_defencoding = 'UTF-8';

function dodajKsiazke($Nazwa,$Autor,$Kategoria,$Lektura)
  {
    $connect = @new mysqli("localhost","root","","ksiazki");
    $result="Dodanie nieudane";
    if((strlen($Nazwa)>0&&strlen($Kategoria)>0&&strlen($Autor)>0)&&($Lektura=="True"||$Lektura=="False"))
    {
    mysqli_query($connect,"INSERT INTO `ksiazki` (`Nazwa`, `Autor`, `Kategoria`, `Lektura`)
        VALUES ('".$Nazwa."', '".$Autor."', '".$Kategoria."','".$Lektura."');");
        $result="Dodano pomyślnie";
      }
        return new soapval('return', 'xsd:int', $result);
  }

$postdata = file_get_contents("php://input");

$postdata = isset($postdata) ? $postdata : '';

$server->service($postdata);
 ?>
