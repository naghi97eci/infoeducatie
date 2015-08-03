<?php
use Input;
namespace App\Http\Controllers;
use App\Profesori;
use App\Student;
use App\Orarprof;
use App\Orarstudenti;
use Illuminate\Http\Request;
use Auth;
use App\Http\Requests;
use App\Http\Controllers\Controller;
use Input;
use DB;
use App\Situatiescolara;

class PagesController extends Controller
{
	
    public function index(){

    	//Directionarea catre viewul indexului
 		if (Auth::guest()){
    	return view('index');
		}
		else return redirect('/elevi');    	
  	}

    public function elevi(){

    	// Pentru filtrare
    	$nume = Input::get('nume');

    	$prenume = Input::get('prenume');

    	$materie = Input::get('materie');

		$student = Student::all();

		//Verificam daca userul a filtrat, iar daca da sa afiseze unde se gaseste itemul ce l-a filrtat
		if (!empty($nume)) {
			$student = $student->where('Nume', $nume);
		}

		if (!empty($prenume)) {
			$student = $student->where('Prenume', $prenume);
		}

		if (!empty($materie)) {
			$student = $student->where('Materie', $materie);
		}
	   	

    	return view('elevi', compact('student'));

    }

    public function profesori(){

    	$nume = Input::get('nume');

    	$prenume = Input::get('prenume');

    	$materie = Input::get('materie');

		$profesor = Profesori::all();

		if (!empty($nume)) {
			$profesor = $profesor->where('Nume', $nume);
		}

		if (!empty($prenume)) {
			$profesor = $profesor->where('Prenume', $prenume);
		}

		if (!empty($materie)) {
			$profesor = $profesor->where('Materie', $materie);
		}

    	return view('profesori', compact('profesor'));

    }
    
    public function orarelevi(){

    	$clasa = Input::get('clasa');

    	$diriginte = Input::get('diriginte');

    	$materie = Input::get('materie');

		$orarstudent = Orarstudenti::all();

		if (!empty($clasa)) {
			$orarstudent = $orarstudent->where('Clasa', $clasa);
		}

		if (!empty($diriginte)) {
			$orarstudent= $orarstudent->where('Diriginte', $diriginte);
		}

		if (!empty($materie)) {
			$orarstudent = $orarstudent->where('Materie', $materie);
		}

    	return view('orarelevi', compact('orarstudent'));

    }
    
     public function orarprof(){

    	$materie = Input::get('materie');

    	$profesor = Input::get('profesor');

    	$ora = Input::get('ora');

		$orarprof = Orarprof::all();


		if (!empty($materie)) {
			$orarprof = $orarprof->where('Materie', $materie);
		}

		if (!empty($profesor)) {
			$orarprof= $orarprof->where('Profesor', $profesor);
		}

		if (!empty($ora)) {
			$orarprof = $orarprof->where('Ora', $ora);
		}

    	return view('orarprof', compact('orarprof'));

    }

    public function situatie(){
    	$situatie = Situatiescolara::all();
    	return view('situatie', compact('situatie'));
    }

}
