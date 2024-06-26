* {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
}

body {
    font-family: sans-serif;
    font-size: 100%;
}

h1 {
    text-align: center;
    margin-top: 5%;
    margin-bottom: 5%;
}

.section {
    position: relative;
    clear: both;
    color: black;
    background-color: #32CD32;
    padding: 10px;
    font-size: 100%;
    border: 3px solid black;
    margin-left: 15px;
    margin-bottom: 15px;
    margin-right: 15px;
    display: grid;
    grid-template-columns: 70% 30%;
    gap: 15px;
}

.caption {
    padding: 10px;
    background-color: rgba(255, 255, 255, 0.8);
    border-bottom: 1px solid #000;
    text-align: center;
    font-size: 1rem;
    position: absolute;
    top: 0;
    right: 0;
    width: 30%;
}
.caption + p {
    margin-top: 20px; 
    text-align: center;
}

.caption1 {
    background-color: #C0C0C0;
}

.caption2 {
    background-color: #FFD700;
}

.caption3 {
    background-color: #DDA0DD;
}

.row {
    display: grid;
    grid-template-columns: repeat(12, 1fr);
    gap: 15px;
}

[class^="col-"] {
    padding: 0;
}

@media (min-width: 992px) {
    .col-lg-1 { grid-column: span 1; }
    .col-lg-2 { grid-column: span 2; }
    .col-lg-3 { grid-column: span 3; }
    .col-lg-4 { grid-column: span 4; }
    .col-lg-5 { grid-column: span 5; }
    .col-lg-6 { grid-column: span 6; }
    .col-lg-7 { grid-column: span 7; }
    .col-lg-8 { grid-column: span 8; }
    .col-lg-9 { grid-column: span 9; }
    .col-lg-10 { grid-column: span 10; }
    .col-lg-11 { grid-column: span 11; }
    .col-lg-12 { grid-column: span 12; }
}

@media (min-width: 768px) and (max-width: 991px) {
    .col-md-1 { grid-column: span 1; }
    .col-md-2 { grid-column: span 2; }
    .col-md-3 { grid-column: span 3; }
    .col-md-4 { grid-column: span 4; }
    .col-md-5 { grid-column: span 5; }
    .col-md-6 { grid-column: span 6; }
    .col-md-7 { grid-column: span 7; }
    .col-md-8 { grid-column: span 8; }
    .col-md-9 { grid-column: span 9; }
    .col-md-10 { grid-column: span 10; }
    .col-md-11 { grid-column: span 11; }
    .col-md-12 { grid-column: span 12; }
}

@media (max-width: 767px) {
    .col-sm-1 { grid-column: span 1; }
    .col-sm-2 { grid-column: span 2; }
    .col-sm-3 { grid-column: span 3; }
    .col-sm-4 { grid-column: span 4; }
    .col-sm-5 { grid-column: span 5; }
    .col-sm-6 { grid-column: span 6; }
    .col-sm-7 { grid-column: span 7; }
    .col-sm-8 { grid-column: span 8; }
    .col-sm-9 { grid-column: span 9; }
    .col-sm-10 { grid-column: span 10; }
    .col-sm-11 { grid-column: span 11;}
    .col-sm-11 { grid-column: span 11; }
    .col-sm-12 { grid-column: span 12; }
}
