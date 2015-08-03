@extends('layout')
@section('content')
 <div class="container-fluid">
      <div class="row">
        <div class="col-sm-3 col-md-2 sidebar">
          <ul class="nav nav-sidebar">
            <li ><a href="/elevi">Elevi</a></li>
            <li ><a href="/profesori">Profesori</a></li>
          </ul>
          <ul class="nav nav-sidebar">
            <li ><a href="/orarelevi">Orar elevi</a></li>
            <li class="active" ><a href="/orarprof">Orar profesori</a></li>
          </ul>
          <ul class="nav nav-sidebar">
            <li><a href="/situatiescolara">Situatie scolara elevi</a></li>
          </ul>
        </div>


      <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">

      <div class="jumbotron">
      <div class="row" style="margin-bottom:10px;">
      <div class="col-lg-4">
        <div class="input-group">
          <form  action="/orarprof" method="get">
            <input type="text" class="form-control" placeholder="Materie" name="materie">
            <span class="input-group-btn">
              <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
            </span>
          </form>
        </div>
      </div>
      <div class="col-lg-4">
        <div class="input-group">
          <form  action="/orarprof" method="get">
            <input type="text" class="form-control" placeholder="Profesor" name="profesor">
            <span class="input-group-btn">
              <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
            </span>
          </form>
        </div>
      </div>
      <div class="col-lg-4">
        <div class="input-group">
          <form  action="/orarprof" method="get">
           <input type="text" class="form-control" placeholder="Ora" name="ora">
            <span class="input-group-btn">
              <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
            </span>
          </form>
        </div>
      </div>
        
    </div>
  

  <!-- Table -->
   <div class="table-responsive">
            <table class="table table-striped">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Ora</th>
                  <th>Profesor</th>
                  <th>Materie</th>
                  <th>Luni</th>
              	  <th>Marti</th>
              	  <th>Miercuri</th>
                  <th>Joi</th>
                  <th>Vineri</th>
                </tr>
              </thead>
              <tbody>
              @foreach($orarprof as $orarprofi)
                <tr>
                  <td>{{ $orarprofi->ID }} </td>
                  <td>{{ $orarprofi->Ora }}</td>
                  <td>{{ $orarprofi->Profesor }}</td>
                  <td>{{ $orarprofi->Materie }}</td>
                  <td> {{ $orarprofi->Luni }}</td>
                  <td>{{ $orarprofi->Marti }}</td>
                  <td>{{ $orarprofi->Miercuri }}</td>
                  <td>{{ $orarprofi->Joi }}</td>
                  <td>{{ $orarprofi->Vineri }}</td>
                </tr>
               @endforeach
              </tbody>
            </table>
</div>


</div>
  </div>
      </div>
@stop