html {
    -ms-text-size-adjust: 100%;
    -webkit-text-size-adjust: 100%;
    font-family: sans-serif;
  }
  
  body {
    margin: 0;
  }
  
  article, aside, details, figcaption, figure, footer, header, hgroup, main, menu, nav, section, summary {
    display: block;
  }
  
  audio, canvas, progress, video {
    vertical-align: baseline;
    display: inline-block;
  }
  
  audio:not([controls]) {
    height: 0;
    display: none;
  }
  
  [hidden], template {
    display: none;
  }
  
  a {
    background-color: rgba(0, 0, 0, 0);
  }
  
  a:active, a:hover {
    outline: 0;
  }
  
  abbr[title] {
    border-bottom: 1px dotted;
  }
  
  b, strong {
    font-weight: bold;
  }
  
  dfn {
    font-style: italic;
  }
  
  h1 {
    margin: .67em 0;
    font-size: 2em;
  }
  
  mark {
    color: #000;
    background: #ff0;
  }
  
  small {
    font-size: 80%;
  }
  
  sub, sup {
    vertical-align: baseline;
    font-size: 75%;
    line-height: 0;
    position: relative;
  }
  
  sup {
    top: -.5em;
  }
  
  sub {
    bottom: -.25em;
  }
  
  img {
    border: 0;
  }
  
  svg:not(:root) {
    overflow: hidden;
  }
  
  figure {
    margin: 1em 40px;
  }
  
  hr {
    box-sizing: content-box;
    height: 0;
  }
  
  pre {
    overflow: auto;
  }
  
  code, kbd, pre, samp {
    font-family: monospace;
    font-size: 1em;
  }
  
  button, input, optgroup, select, textarea {
    color: inherit;
    font: inherit;
    margin: 0;
  }
  
  button {
    overflow: visible;
  }
  
  button, select {
    text-transform: none;
  }
  
  button, html input[type="button"], input[type="reset"] {
    -webkit-appearance: button;
    cursor: pointer;
  }
  
  button[disabled], html input[disabled] {
    cursor: default;
  }
  
  button::-moz-focus-inner, input::-moz-focus-inner {
    border: 0;
    padding: 0;
  }
  
  input {
    line-height: normal;
  }
  
  input[type="checkbox"], input[type="radio"] {
    box-sizing: border-box;
    padding: 0;
  }
  
  input[type="number"]::-webkit-inner-spin-button, input[type="number"]::-webkit-outer-spin-button {
    height: auto;
  }
  
  input[type="search"] {
    -webkit-appearance: none;
  }
  
  input[type="search"]::-webkit-search-cancel-button, input[type="search"]::-webkit-search-decoration {
    -webkit-appearance: none;
  }
  
  fieldset {
    border: 1px solid silver;
    margin: 0 2px;
    padding: .35em .625em .75em;
  }
  
  legend {
    border: 0;
    padding: 0;
  }
  
  textarea {
    overflow: auto;
  }
  
  optgroup {
    font-weight: bold;
  }
  
  table {
    border-collapse: collapse;
    border-spacing: 0;
  }
  
  td, th {
    padding: 0;
  }
  
  @font-face {
    font-family: webflow-icons;
    src: url("data:application/x-font-ttf;charset=utf-8;base64,AAEAAAALAIAAAwAwT1MvMg8SBiUAAAC8AAAAYGNtYXDpP+a4AAABHAAAAFxnYXNwAAAAEAAAAXgAAAAIZ2x5ZmhS2XEAAAGAAAADHGhlYWQTFw3HAAAEnAAAADZoaGVhCXYFgQAABNQAAAAkaG10eCe4A1oAAAT4AAAAMGxvY2EDtALGAAAFKAAAABptYXhwABAAPgAABUQAAAAgbmFtZSoCsMsAAAVkAAABznBvc3QAAwAAAAAHNAAAACAAAwP4AZAABQAAApkCzAAAAI8CmQLMAAAB6wAzAQkAAAAAAAAAAAAAAAAAAAABEAAAAAAAAAAAAAAAAAAAAABAAADpAwPA/8AAQAPAAEAAAAABAAAAAAAAAAAAAAAgAAAAAAADAAAAAwAAABwAAQADAAAAHAADAAEAAAAcAAQAQAAAAAwACAACAAQAAQAg5gPpA//9//8AAAAAACDmAOkA//3//wAB/+MaBBcIAAMAAQAAAAAAAAAAAAAAAAABAAH//wAPAAEAAAAAAAAAAAACAAA3OQEAAAAAAQAAAAAAAAAAAAIAADc5AQAAAAABAAAAAAAAAAAAAgAANzkBAAAAAAEBIAAAAyADgAAFAAAJAQcJARcDIP5AQAGA/oBAAcABwED+gP6AQAABAOAAAALgA4AABQAAEwEXCQEH4AHAQP6AAYBAAcABwED+gP6AQAAAAwDAAOADQALAAA8AHwAvAAABISIGHQEUFjMhMjY9ATQmByEiBh0BFBYzITI2PQE0JgchIgYdARQWMyEyNj0BNCYDIP3ADRMTDQJADRMTDf3ADRMTDQJADRMTDf3ADRMTDQJADRMTAsATDSANExMNIA0TwBMNIA0TEw0gDRPAEw0gDRMTDSANEwAAAAABAJ0AtAOBApUABQAACQIHCQEDJP7r/upcAXEBcgKU/usBFVz+fAGEAAAAAAL//f+9BAMDwwAEAAkAABcBJwEXAwE3AQdpA5ps/GZsbAOabPxmbEMDmmz8ZmwDmvxmbAOabAAAAgAA/8AEAAPAAB0AOwAABSInLgEnJjU0Nz4BNzYzMTIXHgEXFhUUBw4BBwYjNTI3PgE3NjU0Jy4BJyYjMSIHDgEHBhUUFx4BFxYzAgBqXV6LKCgoKIteXWpqXV6LKCgoKIteXWpVSktvICEhIG9LSlVVSktvICEhIG9LSlVAKCiLXl1qal1eiygoKCiLXl1qal1eiygoZiEgb0tKVVVKS28gISEgb0tKVVVKS28gIQABAAABwAIAA8AAEgAAEzQ3PgE3NjMxFSIHDgEHBhUxIwAoKIteXWpVSktvICFmAcBqXV6LKChmISBvS0pVAAAAAgAA/8AFtgPAADIAOgAAARYXHgEXFhUUBw4BBwYHIxUhIicuAScmNTQ3PgE3NjMxOAExNDc+ATc2MzIXHgEXFhcVATMJATMVMzUEjD83NlAXFxYXTjU1PQL8kz01Nk8XFxcXTzY1PSIjd1BQWlJJSXInJw3+mdv+2/7c25MCUQYcHFg5OUA/ODlXHBwIAhcXTzY1PTw1Nk8XF1tQUHcjIhwcYUNDTgL+3QFt/pOTkwABAAAAAQAAmM7nP18PPPUACwQAAAAAANciZKUAAAAA1yJkpf/9/70FtgPDAAAACAACAAAAAAAAAAEAAAPA/8AAAAW3//3//QW2AAEAAAAAAAAAAAAAAAAAAAAMBAAAAAAAAAAAAAAAAgAAAAQAASAEAADgBAAAwAQAAJ0EAP/9BAAAAAQAAAAFtwAAAAAAAAAKABQAHgAyAEYAjACiAL4BFgE2AY4AAAABAAAADAA8AAMAAAAAAAIAAAAAAAAAAAAAAAAAAAAAAAAADgCuAAEAAAAAAAEADQAAAAEAAAAAAAIABwCWAAEAAAAAAAMADQBIAAEAAAAAAAQADQCrAAEAAAAAAAUACwAnAAEAAAAAAAYADQBvAAEAAAAAAAoAGgDSAAMAAQQJAAEAGgANAAMAAQQJAAIADgCdAAMAAQQJAAMAGgBVAAMAAQQJAAQAGgC4AAMAAQQJAAUAFgAyAAMAAQQJAAYAGgB8AAMAAQQJAAoANADsd2ViZmxvdy1pY29ucwB3AGUAYgBmAGwAbwB3AC0AaQBjAG8AbgBzVmVyc2lvbiAxLjAAVgBlAHIAcwBpAG8AbgAgADEALgAwd2ViZmxvdy1pY29ucwB3AGUAYgBmAGwAbwB3AC0AaQBjAG8AbgBzd2ViZmxvdy1pY29ucwB3AGUAYgBmAGwAbwB3AC0AaQBjAG8AbgBzUmVndWxhcgBSAGUAZwB1AGwAYQByd2ViZmxvdy1pY29ucwB3AGUAYgBmAGwAbwB3AC0AaQBjAG8AbgBzRm9udCBnZW5lcmF0ZWQgYnkgSWNvTW9vbi4ARgBvAG4AdAAgAGcAZQBuAGUAcgBhAHQAZQBkACAAYgB5ACAASQBjAG8ATQBvAG8AbgAuAAAAAwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==") format("truetype");
    font-weight: normal;
    font-style: normal;
  }
  
  [class^="w-icon-"], [class*=" w-icon-"] {
    speak: none;
    font-variant: normal;
    text-transform: none;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    font-style: normal;
    font-weight: normal;
    line-height: 1;
    font-family: webflow-icons !important;
  }
  
  .w-icon-slider-right:before {
    content: "î˜€";
  }
  
  .w-icon-slider-left:before {
    content: "î˜";
  }
  
  .w-icon-nav-menu:before {
    content: "î˜‚";
  }
  
  .w-icon-arrow-down:before, .w-icon-dropdown-toggle:before {
    content: "î˜ƒ";
  }
  
  .w-icon-file-upload-remove:before {
    content: "î¤€";
  }
  
  .w-icon-file-upload-icon:before {
    content: "î¤ƒ";
  }
  
  * {
    box-sizing: border-box;
  }
  
  html {
    height: 100%;
  }
  
  body {
    min-height: 100%;
    color: #333;
    background-color: #fff;
    margin: 0;
    font-family: Arial, sans-serif;
    font-size: 14px;
    line-height: 20px;
  }
  
  img {
    max-width: 100%;
    vertical-align: middle;
    display: inline-block;
  }
  
  html.w-mod-touch * {
    background-attachment: scroll !important;
  }
  
  .w-block {
    display: block;
  }
  
  .w-inline-block {
    max-width: 100%;
    display: inline-block;
  }
  
  .w-clearfix:before, .w-clearfix:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-clearfix:after {
    clear: both;
  }
  
  .w-hidden {
    display: none;
  }
  
  .w-button {
    color: #fff;
    line-height: inherit;
    cursor: pointer;
    background-color: #3898ec;
    border: 0;
    border-radius: 0;
    padding: 9px 15px;
    text-decoration: none;
    display: inline-block;
  }
  
  input.w-button {
    -webkit-appearance: button;
  }
  
  html[data-w-dynpage] [data-w-cloak] {
    color: rgba(0, 0, 0, 0) !important;
  }
  
  .w-webflow-badge, .w-webflow-badge * {
   return;
  }
  
  .w-webflow-badge {
    return ;
  }
  
  .w-webflow-badge > img {
    return ;
  }
  
  h1, h2, h3, h4, h5, h6 {
    margin-bottom: 10px;
    font-weight: bold;
  }
  
  h1 {
    margin-top: 20px;
    font-size: 38px;
    line-height: 44px;
  }
  
  h2 {
    margin-top: 20px;
    font-size: 32px;
    line-height: 36px;
  }
  
  h3 {
    margin-top: 20px;
    font-size: 24px;
    line-height: 30px;
  }
  
  h4 {
    margin-top: 10px;
    font-size: 18px;
    line-height: 24px;
  }
  
  h5 {
    margin-top: 10px;
    font-size: 14px;
    line-height: 20px;
  }
  
  h6 {
    margin-top: 10px;
    font-size: 12px;
    line-height: 18px;
  }
  
  p {
    margin-top: 0;
    margin-bottom: 10px;
  }
  
  blockquote {
    border-left: 5px solid #e2e2e2;
    margin: 0 0 10px;
    padding: 10px 20px;
    font-size: 18px;
    line-height: 22px;
  }
  
  figure {
    margin: 0 0 10px;
  }
  
  figcaption {
    text-align: center;
    margin-top: 5px;
  }
  
  ul, ol {
    margin-top: 0;
    margin-bottom: 10px;
    padding-left: 40px;
  }
  
  .w-list-unstyled {
    padding-left: 0;
    list-style: none;
  }
  
  .w-embed:before, .w-embed:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-embed:after {
    clear: both;
  }
  
  .w-video {
    width: 100%;
    padding: 0;
    position: relative;
  }
  
  .w-video iframe, .w-video object, .w-video embed {
    width: 100%;
    height: 100%;
    border: none;
    position: absolute;
    top: 0;
    left: 0;
  }
  
  fieldset {
    border: 0;
    margin: 0;
    padding: 0;
  }
  
  button, [type="button"], [type="reset"] {
    cursor: pointer;
    -webkit-appearance: button;
    border: 0;
  }
  
  .w-form {
    margin: 0 0 15px;
  }
  
  .w-form-done {
    text-align: center;
    background-color: #ddd;
    padding: 20px;
    display: none;
  }
  
  .w-form-fail {
    background-color: #ffdede;
    margin-top: 10px;
    padding: 10px;
    display: none;
  }
  
  label {
    margin-bottom: 5px;
    font-weight: bold;
    display: block;
  }
  
  .w-input, .w-select {
    width: 100%;
    height: 38px;
    color: #333;
    vertical-align: middle;
    background-color: #fff;
    border: 1px solid #ccc;
    margin-bottom: 10px;
    padding: 8px 12px;
    font-size: 14px;
    line-height: 1.42857;
    display: block;
  }
  
  .w-input:-moz-placeholder, .w-select:-moz-placeholder {
    color: #999;
  }
  
  .w-input::-moz-placeholder, .w-select::-moz-placeholder {
    color: #999;
    opacity: 1;
  }
  
  .w-input::-webkit-input-placeholder, .w-select::-webkit-input-placeholder {
    color: #999;
  }
  
  .w-input:focus, .w-select:focus {
    border-color: #3898ec;
    outline: 0;
  }
  
  .w-input[disabled], .w-select[disabled], .w-input[readonly], .w-select[readonly], fieldset[disabled] .w-input, fieldset[disabled] .w-select {
    cursor: not-allowed;
  }
  
  .w-input[disabled]:not(.w-input-disabled), .w-select[disabled]:not(.w-input-disabled), .w-input[readonly], .w-select[readonly], fieldset[disabled]:not(.w-input-disabled) .w-input, fieldset[disabled]:not(.w-input-disabled) .w-select {
    background-color: #eee;
  }
  
  textarea.w-input, textarea.w-select {
    height: auto;
  }
  
  .w-select {
    background-color: #f3f3f3;
  }
  
  .w-select[multiple] {
    height: auto;
  }
  
  .w-form-label {
    cursor: pointer;
    margin-bottom: 0;
    font-weight: normal;
    display: inline-block;
  }
  
  .w-radio {
    margin-bottom: 5px;
    padding-left: 20px;
    display: block;
  }
  
  .w-radio:before, .w-radio:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-radio:after {
    clear: both;
  }
  
  .w-radio-input {
    float: left;
    margin: 3px 0 0 -20px;
    line-height: normal;
  }
  
  .w-file-upload {
    margin-bottom: 10px;
    display: block;
  }
  
  .w-file-upload-input {
    width: .1px;
    height: .1px;
    opacity: 0;
    z-index: -100;
    position: absolute;
    overflow: hidden;
  }
  
  .w-file-upload-default, .w-file-upload-uploading, .w-file-upload-success {
    color: #333;
    display: inline-block;
  }
  
  .w-file-upload-error {
    margin-top: 10px;
    display: block;
  }
  
  .w-file-upload-default.w-hidden, .w-file-upload-uploading.w-hidden, .w-file-upload-error.w-hidden, .w-file-upload-success.w-hidden {
    display: none;
  }
  
  .w-file-upload-uploading-btn {
    cursor: pointer;
    background-color: #fafafa;
    border: 1px solid #ccc;
    margin: 0;
    padding: 8px 12px;
    font-size: 14px;
    font-weight: normal;
    display: flex;
  }
  
  .w-file-upload-file {
    background-color: #fafafa;
    border: 1px solid #ccc;
    flex-grow: 1;
    justify-content: space-between;
    margin: 0;
    padding: 8px 9px 8px 11px;
    display: flex;
  }
  
  .w-file-upload-file-name {
    font-size: 14px;
    font-weight: normal;
    display: block;
  }
  
  .w-file-remove-link {
    width: auto;
    height: auto;
    cursor: pointer;
    margin-top: 3px;
    margin-left: 10px;
    padding: 3px;
    display: block;
  }
  
  .w-icon-file-upload-remove {
    margin: auto;
    font-size: 10px;
  }
  
  .w-file-upload-error-msg {
    color: #ea384c;
    padding: 2px 0;
    display: inline-block;
  }
  
  .w-file-upload-info {
    padding: 0 12px;
    line-height: 38px;
    display: inline-block;
  }
  
  .w-file-upload-label {
    cursor: pointer;
    background-color: #fafafa;
    border: 1px solid #ccc;
    margin: 0;
    padding: 8px 12px;
    font-size: 14px;
    font-weight: normal;
    display: inline-block;
  }
  
  .w-icon-file-upload-icon, .w-icon-file-upload-uploading {
    width: 20px;
    margin-right: 8px;
    display: inline-block;
  }
  
  .w-icon-file-upload-uploading {
    height: 20px;
  }
  
  .w-container {
    max-width: 940px;
    margin-left: auto;
    margin-right: auto;
  }
  
  .w-container:before, .w-container:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-container:after {
    clear: both;
  }
  
  .w-container .w-row {
    margin-left: -10px;
    margin-right: -10px;
  }
  
  .w-row:before, .w-row:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-row:after {
    clear: both;
  }
  
  .w-row .w-row {
    margin-left: 0;
    margin-right: 0;
  }
  
  .w-col {
    float: left;
    width: 100%;
    min-height: 1px;
    padding-left: 10px;
    padding-right: 10px;
    position: relative;
  }
  
  .w-col .w-col {
    padding-left: 0;
    padding-right: 0;
  }
  
  .w-col-1 {
    width: 8.33333%;
  }
  
  .w-col-2 {
    width: 16.6667%;
  }
  
  .w-col-3 {
    width: 25%;
  }
  
  .w-col-4 {
    width: 33.3333%;
  }
  
  .w-col-5 {
    width: 41.6667%;
  }
  
  .w-col-6 {
    width: 50%;
  }
  
  .w-col-7 {
    width: 58.3333%;
  }
  
  .w-col-8 {
    width: 66.6667%;
  }
  
  .w-col-9 {
    width: 75%;
  }
  
  .w-col-10 {
    width: 83.3333%;
  }
  
  .w-col-11 {
    width: 91.6667%;
  }
  
  .w-col-12 {
    width: 100%;
  }
  
  .w-hidden-main {
    display: none !important;
  }
  
  @media screen and (max-width: 991px) {
    .w-container {
      max-width: 728px;
    }
  
    .w-hidden-main {
      display: inherit !important;
    }
  
    .w-hidden-medium {
      display: none !important;
    }
  
    .w-col-medium-1 {
      width: 8.33333%;
    }
  
    .w-col-medium-2 {
      width: 16.6667%;
    }
  
    .w-col-medium-3 {
      width: 25%;
    }
  
    .w-col-medium-4 {
      width: 33.3333%;
    }
  
    .w-col-medium-5 {
      width: 41.6667%;
    }
  
    .w-col-medium-6 {
      width: 50%;
    }
  
    .w-col-medium-7 {
      width: 58.3333%;
    }
  
    .w-col-medium-8 {
      width: 66.6667%;
    }
  
    .w-col-medium-9 {
      width: 75%;
    }
  
    .w-col-medium-10 {
      width: 83.3333%;
    }
  
    .w-col-medium-11 {
      width: 91.6667%;
    }
  
    .w-col-medium-12 {
      width: 100%;
    }
  
    .w-col-stack {
      width: 100%;
      left: auto;
      right: auto;
    }
  }
  
  @media screen and (max-width: 767px) {
    .w-hidden-main, .w-hidden-medium {
      display: inherit !important;
    }
  
    .w-hidden-small {
      display: none !important;
    }
  
    .w-row, .w-container .w-row {
      margin-left: 0;
      margin-right: 0;
    }
  
    .w-col {
      width: 100%;
      left: auto;
      right: auto;
    }
  
    .w-col-small-1 {
      width: 8.33333%;
    }
  
    .w-col-small-2 {
      width: 16.6667%;
    }
  
    .w-col-small-3 {
      width: 25%;
    }
  
    .w-col-small-4 {
      width: 33.3333%;
    }
  
    .w-col-small-5 {
      width: 41.6667%;
    }
  
    .w-col-small-6 {
      width: 50%;
    }
  
    .w-col-small-7 {
      width: 58.3333%;
    }
  
    .w-col-small-8 {
      width: 66.6667%;
    }
  
    .w-col-small-9 {
      width: 75%;
    }
  
    .w-col-small-10 {
      width: 83.3333%;
    }
  
    .w-col-small-11 {
      width: 91.6667%;
    }
  
    .w-col-small-12 {
      width: 100%;
    }
  }
  
  @media screen and (max-width: 479px) {
    .w-container {
      max-width: none;
    }
  
    .w-hidden-main, .w-hidden-medium, .w-hidden-small {
      display: inherit !important;
    }
  
    .w-hidden-tiny {
      display: none !important;
    }
  
    .w-col {
      width: 100%;
    }
  
    .w-col-tiny-1 {
      width: 8.33333%;
    }
  
    .w-col-tiny-2 {
      width: 16.6667%;
    }
  
    .w-col-tiny-3 {
      width: 25%;
    }
  
    .w-col-tiny-4 {
      width: 33.3333%;
    }
  
    .w-col-tiny-5 {
      width: 41.6667%;
    }
  
    .w-col-tiny-6 {
      width: 50%;
    }
  
    .w-col-tiny-7 {
      width: 58.3333%;
    }
  
    .w-col-tiny-8 {
      width: 66.6667%;
    }
  
    .w-col-tiny-9 {
      width: 75%;
    }
  
    .w-col-tiny-10 {
      width: 83.3333%;
    }
  
    .w-col-tiny-11 {
      width: 91.6667%;
    }
  
    .w-col-tiny-12 {
      width: 100%;
    }
  }
  
  .w-widget {
    position: relative;
  }
  
  .w-widget-map {
    width: 100%;
    height: 400px;
  }
  
  .w-widget-map label {
    width: auto;
    display: inline;
  }
  
  .w-widget-map img {
    max-width: inherit;
  }
  
  .w-widget-map .gm-style-iw {
    text-align: center;
  }
  
  .w-widget-map .gm-style-iw > button {
    display: none !important;
  }
  
  .w-widget-twitter {
    overflow: hidden;
  }
  
  .w-widget-twitter-count-shim {
    vertical-align: top;
    width: 28px;
    height: 20px;
    text-align: center;
    background: #fff;
    border: 1px solid #758696;
    border-radius: 3px;
    display: inline-block;
    position: relative;
  }
  
  .w-widget-twitter-count-shim * {
    pointer-events: none;
    -webkit-user-select: none;
    -ms-user-select: none;
    user-select: none;
  }
  
  .w-widget-twitter-count-shim .w-widget-twitter-count-inner {
    text-align: center;
    color: #999;
    font-family: serif;
    font-size: 15px;
    line-height: 12px;
    position: relative;
  }
  
  .w-widget-twitter-count-shim .w-widget-twitter-count-clear {
    display: block;
    position: relative;
  }
  
  .w-widget-twitter-count-shim.w--large {
    width: 36px;
    height: 28px;
  }
  
  .w-widget-twitter-count-shim.w--large .w-widget-twitter-count-inner {
    font-size: 18px;
    line-height: 18px;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical) {
    margin-left: 5px;
    margin-right: 8px;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical).w--large {
    margin-left: 6px;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical):before, .w-widget-twitter-count-shim:not(.w--vertical):after {
    content: " ";
    height: 0;
    width: 0;
    pointer-events: none;
    border: solid rgba(0, 0, 0, 0);
    position: absolute;
    top: 50%;
    left: 0;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical):before {
    border-width: 4px;
    border-color: rgba(117, 134, 150, 0) #5d6c7b rgba(117, 134, 150, 0) rgba(117, 134, 150, 0);
    margin-top: -4px;
    margin-left: -9px;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical).w--large:before {
    border-width: 5px;
    margin-top: -5px;
    margin-left: -10px;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical):after {
    border-width: 4px;
    border-color: rgba(255, 255, 255, 0) #fff rgba(255, 255, 255, 0) rgba(255, 255, 255, 0);
    margin-top: -4px;
    margin-left: -8px;
  }
  
  .w-widget-twitter-count-shim:not(.w--vertical).w--large:after {
    border-width: 5px;
    margin-top: -5px;
    margin-left: -9px;
  }
  
  .w-widget-twitter-count-shim.w--vertical {
    width: 61px;
    height: 33px;
    margin-bottom: 8px;
  }
  
  .w-widget-twitter-count-shim.w--vertical:before, .w-widget-twitter-count-shim.w--vertical:after {
    content: " ";
    height: 0;
    width: 0;
    pointer-events: none;
    border: solid rgba(0, 0, 0, 0);
    position: absolute;
    top: 100%;
    left: 50%;
  }
  
  .w-widget-twitter-count-shim.w--vertical:before {
    border-width: 5px;
    border-color: #5d6c7b rgba(117, 134, 150, 0) rgba(117, 134, 150, 0);
    margin-left: -5px;
  }
  
  .w-widget-twitter-count-shim.w--vertical:after {
    border-width: 4px;
    border-color: #fff rgba(255, 255, 255, 0) rgba(255, 255, 255, 0);
    margin-left: -4px;
  }
  
  .w-widget-twitter-count-shim.w--vertical .w-widget-twitter-count-inner {
    font-size: 18px;
    line-height: 22px;
  }
  
  .w-widget-twitter-count-shim.w--vertical.w--large {
    width: 76px;
  }
  
  .w-background-video {
    height: 500px;
    color: #fff;
    position: relative;
    overflow: hidden;
  }
  
  .w-background-video > video {
    width: 100%;
    height: 100%;
    object-fit: cover;
    z-index: -100;
    background-position: 50%;
    background-size: cover;
    margin: auto;
    position: absolute;
    top: -100%;
    bottom: -100%;
    left: -100%;
    right: -100%;
  }
  
  .w-background-video > video::-webkit-media-controls-start-playback-button {
    -webkit-appearance: none;
    display: none !important;
  }
  
  .w-background-video--control {
    background-color: rgba(0, 0, 0, 0);
    padding: 0;
    position: absolute;
    bottom: 1em;
    right: 1em;
  }
  
  .w-background-video--control > [hidden] {
    display: none !important;
  }
  
  .w-slider {
    height: 300px;
    text-align: center;
    clear: both;
    -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
    tap-highlight-color: rgba(0, 0, 0, 0);
    background: #ddd;
    position: relative;
  }
  
  .w-slider-mask {
    z-index: 1;
    height: 100%;
    white-space: nowrap;
    display: block;
    position: relative;
    left: 0;
    right: 0;
    overflow: hidden;
  }
  
  .w-slide {
    vertical-align: top;
    width: 100%;
    height: 100%;
    white-space: normal;
    text-align: left;
    display: inline-block;
    position: relative;
  }
  
  .w-slider-nav {
    z-index: 2;
    height: 40px;
    text-align: center;
    -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
    tap-highlight-color: rgba(0, 0, 0, 0);
    margin: auto;
    padding-top: 10px;
    position: absolute;
    top: auto;
    bottom: 0;
    left: 0;
    right: 0;
  }
  
  .w-slider-nav.w-round > div {
    border-radius: 100%;
  }
  
  .w-slider-nav.w-num > div {
    width: auto;
    height: auto;
    font-size: inherit;
    line-height: inherit;
    padding: .2em .5em;
  }
  
  .w-slider-nav.w-shadow > div {
    box-shadow: 0 0 3px rgba(51, 51, 51, .4);
  }
  
  .w-slider-nav-invert {
    color: #fff;
  }
  
  .w-slider-nav-invert > div {
    background-color: rgba(34, 34, 34, .4);
  }
  
  .w-slider-nav-invert > div.w-active {
    background-color: #222;
  }
  
  .w-slider-dot {
    width: 1em;
    height: 1em;
    cursor: pointer;
    background-color: rgba(255, 255, 255, .4);
    margin: 0 3px .5em;
    transition: background-color .1s, color .1s;
    display: inline-block;
    position: relative;
  }
  
  .w-slider-dot.w-active {
    background-color: #fff;
  }
  
  .w-slider-dot:focus {
    outline: none;
    box-shadow: 0 0 0 2px #fff;
  }
  
  .w-slider-dot:focus.w-active {
    box-shadow: none;
  }
  
  .w-slider-arrow-left, .w-slider-arrow-right {
    width: 80px;
    cursor: pointer;
    color: #fff;
    -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
    tap-highlight-color: rgba(0, 0, 0, 0);
    -webkit-user-select: none;
    -ms-user-select: none;
    user-select: none;
    margin: auto;
    font-size: 40px;
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    overflow: hidden;
  }
  
  .w-slider-arrow-left [class^="w-icon-"], .w-slider-arrow-right [class^="w-icon-"], .w-slider-arrow-left [class*=" w-icon-"], .w-slider-arrow-right [class*=" w-icon-"] {
    position: absolute;
  }
  
  .w-slider-arrow-left:focus, .w-slider-arrow-right:focus {
    outline: 0;
  }
  
  .w-slider-arrow-left {
    z-index: 3;
    right: auto;
  }
  
  .w-slider-arrow-right {
    z-index: 4;
    left: auto;
  }
  
  .w-icon-slider-left, .w-icon-slider-right {
    width: 1em;
    height: 1em;
    margin: auto;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
  }
  
  .w-slider-aria-label {
    clip: rect(0 0 0 0);
    height: 1px;
    width: 1px;
    border: 0;
    margin: -1px;
    padding: 0;
    position: absolute;
    overflow: hidden;
  }
  
  .w-slider-force-show {
    display: block !important;
  }
  
  .w-dropdown {
    text-align: left;
    z-index: 900;
    margin-left: auto;
    margin-right: auto;
    display: inline-block;
    position: relative;
  }
  
  .w-dropdown-btn, .w-dropdown-toggle, .w-dropdown-link {
    vertical-align: top;
    color: #222;
    text-align: left;
    white-space: nowrap;
    margin-left: auto;
    margin-right: auto;
    padding: 20px;
    text-decoration: none;
    position: relative;
  }
  
  .w-dropdown-toggle {
    -webkit-user-select: none;
    -ms-user-select: none;
    user-select: none;
    cursor: pointer;
    padding-right: 40px;
    display: inline-block;
  }
  
  .w-dropdown-toggle:focus {
    outline: 0;
  }
  
  .w-icon-dropdown-toggle {
    width: 1em;
    height: 1em;
    margin: auto 20px auto auto;
    position: absolute;
    top: 0;
    bottom: 0;
    right: 0;
  }
  
  .w-dropdown-list {
    min-width: 100%;
    background: #ddd;
    display: none;
    position: absolute;
  }
  
  .w-dropdown-list.w--open {
    display: block;
  }
  
  .w-dropdown-link {
    color: #222;
    padding: 10px 20px;
    display: block;
  }
  
  .w-dropdown-link.w--current {
    color: #0082f3;
  }
  
  .w-dropdown-link:focus {
    outline: 0;
  }
  
  @media screen and (max-width: 767px) {
    .w-nav-brand {
      padding-left: 10px;
    }
  }
  
  .w-lightbox-backdrop {
    cursor: auto;
    letter-spacing: normal;
    text-indent: 0;
    text-shadow: none;
    text-transform: none;
    visibility: visible;
    white-space: normal;
    word-break: normal;
    word-spacing: normal;
    word-wrap: normal;
    color: #fff;
    text-align: center;
    z-index: 2000;
    opacity: 0;
    -webkit-user-select: none;
    -moz-user-select: none;
    -webkit-tap-highlight-color: transparent;
    background: rgba(0, 0, 0, .9);
    outline: 0;
    font-family: Helvetica Neue, Helvetica, Ubuntu, Segoe UI, Verdana, sans-serif;
    font-size: 17px;
    font-style: normal;
    font-weight: 300;
    line-height: 1.2;
    list-style: disc;
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    -webkit-transform: translate(0);
  }
  
  .w-lightbox-backdrop, .w-lightbox-container {
    height: 100%;
    -webkit-overflow-scrolling: touch;
    overflow: auto;
  }
  
  .w-lightbox-content {
    height: 100vh;
    position: relative;
    overflow: hidden;
  }
  
  .w-lightbox-view {
    width: 100vw;
    height: 100vh;
    opacity: 0;
    position: absolute;
  }
  
  .w-lightbox-view:before {
    content: "";
    height: 100vh;
  }
  
  .w-lightbox-group, .w-lightbox-group .w-lightbox-view, .w-lightbox-group .w-lightbox-view:before {
    height: 86vh;
  }
  
  .w-lightbox-frame, .w-lightbox-view:before {
    vertical-align: middle;
    display: inline-block;
  }
  
  .w-lightbox-figure {
    margin: 0;
    position: relative;
  }
  
  .w-lightbox-group .w-lightbox-figure {
    cursor: pointer;
  }
  
  .w-lightbox-img {
    width: auto;
    height: auto;
    max-width: none;
  }
  
  .w-lightbox-image {
    float: none;
    max-width: 100vw;
    max-height: 100vh;
    display: block;
  }
  
  .w-lightbox-group .w-lightbox-image {
    max-height: 86vh;
  }
  
  .w-lightbox-caption {
    text-align: left;
    text-overflow: ellipsis;
    white-space: nowrap;
    background: rgba(0, 0, 0, .4);
    padding: .5em 1em;
    position: absolute;
    bottom: 0;
    left: 0;
    right: 0;
    overflow: hidden;
  }
  
  .w-lightbox-embed {
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
  }
  
  .w-lightbox-control {
    width: 4em;
    cursor: pointer;
    background-position: center;
    background-repeat: no-repeat;
    background-size: 24px;
    transition: all .3s;
    position: absolute;
    top: 0;
  }
  
  .w-lightbox-left {
    background-image: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9Ii0yMCAwIDI0IDQwIiB3aWR0aD0iMjQiIGhlaWdodD0iNDAiPjxnIHRyYW5zZm9ybT0icm90YXRlKDQ1KSI+PHBhdGggZD0ibTAgMGg1djIzaDIzdjVoLTI4eiIgb3BhY2l0eT0iLjQiLz48cGF0aCBkPSJtMSAxaDN2MjNoMjN2M2gtMjZ6IiBmaWxsPSIjZmZmIi8+PC9nPjwvc3ZnPg==");
    display: none;
    bottom: 0;
    left: 0;
  }
  
  .w-lightbox-right {
    background-image: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9Ii00IDAgMjQgNDAiIHdpZHRoPSIyNCIgaGVpZ2h0PSI0MCI+PGcgdHJhbnNmb3JtPSJyb3RhdGUoNDUpIj48cGF0aCBkPSJtMC0waDI4djI4aC01di0yM2gtMjN6IiBvcGFjaXR5PSIuNCIvPjxwYXRoIGQ9Im0xIDFoMjZ2MjZoLTN2LTIzaC0yM3oiIGZpbGw9IiNmZmYiLz48L2c+PC9zdmc+");
    display: none;
    bottom: 0;
    right: 0;
  }
  
  .w-lightbox-close {
    height: 2.6em;
    background-image: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9Ii00IDAgMTggMTciIHdpZHRoPSIxOCIgaGVpZ2h0PSIxNyI+PGcgdHJhbnNmb3JtPSJyb3RhdGUoNDUpIj48cGF0aCBkPSJtMCAwaDd2LTdoNXY3aDd2NWgtN3Y3aC01di03aC03eiIgb3BhY2l0eT0iLjQiLz48cGF0aCBkPSJtMSAxaDd2LTdoM3Y3aDd2M2gtN3Y3aC0zdi03aC03eiIgZmlsbD0iI2ZmZiIvPjwvZz48L3N2Zz4=");
    background-size: 18px;
    right: 0;
  }
  
  .w-lightbox-strip {
    white-space: nowrap;
    padding: 0 1vh;
    line-height: 0;
    position: absolute;
    bottom: 0;
    left: 0;
    right: 0;
    overflow-x: auto;
    overflow-y: hidden;
  }
  
  .w-lightbox-item {
    width: 10vh;
    box-sizing: content-box;
    cursor: pointer;
    padding: 2vh 1vh;
    display: inline-block;
    -webkit-transform: translate3d(0, 0, 0);
  }
  
  .w-lightbox-active {
    opacity: .3;
  }
  
  .w-lightbox-thumbnail {
    height: 10vh;
    background: #222;
    position: relative;
    overflow: hidden;
  }
  
  .w-lightbox-thumbnail-image {
    position: absolute;
    top: 0;
    left: 0;
  }
  
  .w-lightbox-thumbnail .w-lightbox-tall {
    width: 100%;
    top: 50%;
    transform: translate(0, -50%);
  }
  
  .w-lightbox-thumbnail .w-lightbox-wide {
    height: 100%;
    left: 50%;
    transform: translate(-50%);
  }
  
  .w-lightbox-spinner {
    box-sizing: border-box;
    width: 40px;
    height: 40px;
    border: 5px solid rgba(0, 0, 0, .4);
    border-radius: 50%;
    margin-top: -20px;
    margin-left: -20px;
    animation: .8s linear infinite spin;
    position: absolute;
    top: 50%;
    left: 50%;
  }
  
  .w-lightbox-spinner:after {
    content: "";
    border: 3px solid rgba(0, 0, 0, 0);
    border-bottom-color: #fff;
    border-radius: 50%;
    position: absolute;
    top: -4px;
    bottom: -4px;
    left: -4px;
    right: -4px;
  }
  
  .w-lightbox-hide {
    display: none;
  }
  
  .w-lightbox-noscroll {
    overflow: hidden;
  }
  
  @media (min-width: 768px) {
    .w-lightbox-content {
      height: 96vh;
      margin-top: 2vh;
    }
  
    .w-lightbox-view, .w-lightbox-view:before {
      height: 96vh;
    }
  
    .w-lightbox-group, .w-lightbox-group .w-lightbox-view, .w-lightbox-group .w-lightbox-view:before {
      height: 84vh;
    }
  
    .w-lightbox-image {
      max-width: 96vw;
      max-height: 96vh;
    }
  
    .w-lightbox-group .w-lightbox-image {
      max-width: 82.3vw;
      max-height: 84vh;
    }
  
    .w-lightbox-left, .w-lightbox-right {
      opacity: .5;
      display: block;
    }
  
    .w-lightbox-close {
      opacity: .8;
    }
  
    .w-lightbox-control:hover {
      opacity: 1;
    }
  }
  
  .w-lightbox-inactive, .w-lightbox-inactive:hover {
    opacity: 0;
  }
  
  .w-richtext:before, .w-richtext:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-richtext:after {
    clear: both;
  }
  
  .w-richtext[contenteditable="true"]:before, .w-richtext[contenteditable="true"]:after {
    white-space: initial;
  }
  
  .w-richtext ol, .w-richtext ul {
    overflow: hidden;
  }
  
  .w-richtext .w-richtext-figure-selected.w-richtext-figure-type-video div:after, .w-richtext .w-richtext-figure-selected[data-rt-type="video"] div:after, .w-richtext .w-richtext-figure-selected.w-richtext-figure-type-image div, .w-richtext .w-richtext-figure-selected[data-rt-type="image"] div {
    outline: 2px solid #2895f7;
  }
  
  .w-richtext figure.w-richtext-figure-type-video > div:after, .w-richtext figure[data-rt-type="video"] > div:after {
    content: "";
    display: none;
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
  }
  
  .w-richtext figure {
    max-width: 60%;
    position: relative;
  }
  
  .w-richtext figure > div:before {
    cursor: default !important;
  }
  
  .w-richtext figure img {
    width: 100%;
  }
  
  .w-richtext figure figcaption.w-richtext-figcaption-placeholder {
    opacity: .6;
  }
  
  .w-richtext figure div {
    color: rgba(0, 0, 0, 0);
    font-size: 0;
  }
  
  .w-richtext figure.w-richtext-figure-type-image, .w-richtext figure[data-rt-type="image"] {
    display: table;
  }
  
  .w-richtext figure.w-richtext-figure-type-image > div, .w-richtext figure[data-rt-type="image"] > div {
    display: inline-block;
  }
  
  .w-richtext figure.w-richtext-figure-type-image > figcaption, .w-richtext figure[data-rt-type="image"] > figcaption {
    caption-side: bottom;
    display: table-caption;
  }
  
  .w-richtext figure.w-richtext-figure-type-video, .w-richtext figure[data-rt-type="video"] {
    width: 60%;
    height: 0;
  }
  
  .w-richtext figure.w-richtext-figure-type-video iframe, .w-richtext figure[data-rt-type="video"] iframe {
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0;
    left: 0;
  }
  
  .w-richtext figure.w-richtext-figure-type-video > div, .w-richtext figure[data-rt-type="video"] > div {
    width: 100%;
  }
  
  .w-richtext figure.w-richtext-align-center {
    clear: both;
    margin-left: auto;
    margin-right: auto;
  }
  
  .w-richtext figure.w-richtext-align-center.w-richtext-figure-type-image > div, .w-richtext figure.w-richtext-align-center[data-rt-type="image"] > div {
    max-width: 100%;
  }
  
  .w-richtext figure.w-richtext-align-normal {
    clear: both;
  }
  
  .w-richtext figure.w-richtext-align-fullwidth {
    width: 100%;
    max-width: 100%;
    text-align: center;
    clear: both;
    margin-left: auto;
    margin-right: auto;
    display: block;
  }
  
  .w-richtext figure.w-richtext-align-fullwidth > div {
    padding-bottom: inherit;
    display: inline-block;
  }
  
  .w-richtext figure.w-richtext-align-fullwidth > figcaption {
    display: block;
  }
  
  .w-richtext figure.w-richtext-align-floatleft {
    float: left;
    clear: none;
    margin-right: 15px;
  }
  
  .w-richtext figure.w-richtext-align-floatright {
    float: right;
    clear: none;
    margin-left: 15px;
  }
  
  .w-nav {
    z-index: 1000;
    background: #ddd;
    position: relative;
  }
  
  .w-nav:before, .w-nav:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-nav:after {
    clear: both;
  }
  
  .w-nav-brand {
    float: left;
    color: #333;
    text-decoration: none;
    position: relative;
  }
  
  .w-nav-link {
    vertical-align: top;
    color: #222;
    text-align: left;
    margin-left: auto;
    margin-right: auto;
    padding: 20px;
    text-decoration: none;
    display: inline-block;
    position: relative;
  }
  
  .w-nav-link.w--current {
    color: #0082f3;
  }
  
  .w-nav-menu {
    float: right;
    position: relative;
  }
  
  [data-nav-menu-open] {
    text-align: center;
    min-width: 200px;
    background: #c8c8c8;
    position: absolute;
    top: 100%;
    left: 0;
    right: 0;
    overflow: visible;
    display: block !important;
  }
  
  .w--nav-link-open {
    display: block;
    position: relative;
  }
  
  .w-nav-overlay {
    width: 100%;
    display: none;
    position: absolute;
    top: 100%;
    left: 0;
    right: 0;
    overflow: hidden;
  }
  
  .w-nav-overlay [data-nav-menu-open] {
    top: 0;
  }
  
  .w-nav[data-animation="over-left"] .w-nav-overlay {
    width: auto;
  }
  
  .w-nav[data-animation="over-left"] .w-nav-overlay, .w-nav[data-animation="over-left"] [data-nav-menu-open] {
    z-index: 1;
    top: 0;
    right: auto;
  }
  
  .w-nav[data-animation="over-right"] .w-nav-overlay {
    width: auto;
  }
  
  .w-nav[data-animation="over-right"] .w-nav-overlay, .w-nav[data-animation="over-right"] [data-nav-menu-open] {
    z-index: 1;
    top: 0;
    left: auto;
  }
  
  .w-nav-button {
    float: right;
    cursor: pointer;
    -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
    tap-highlight-color: rgba(0, 0, 0, 0);
    -webkit-user-select: none;
    -ms-user-select: none;
    user-select: none;
    padding: 18px;
    font-size: 24px;
    display: none;
    position: relative;
  }
  
  .w-nav-button:focus {
    outline: 0;
  }
  
  .w-nav-button.w--open {
    color: #fff;
    background-color: #c8c8c8;
  }
  
  .w-nav[data-collapse="all"] .w-nav-menu {
    display: none;
  }
  
  .w-nav[data-collapse="all"] .w-nav-button, .w--nav-dropdown-open, .w--nav-dropdown-toggle-open {
    display: block;
  }
  
  .w--nav-dropdown-list-open {
    position: static;
  }
  
  @media screen and (max-width: 991px) {
    .w-nav[data-collapse="medium"] .w-nav-menu {
      display: none;
    }
  
    .w-nav[data-collapse="medium"] .w-nav-button {
      display: block;
    }
  }
  
  @media screen and (max-width: 767px) {
    .w-nav[data-collapse="small"] .w-nav-menu {
      display: none;
    }
  
    .w-nav[data-collapse="small"] .w-nav-button {
      display: block;
    }
  
    .w-nav-brand {
      padding-left: 10px;
    }
  }
  
  @media screen and (max-width: 479px) {
    .w-nav[data-collapse="tiny"] .w-nav-menu {
      display: none;
    }
  
    .w-nav[data-collapse="tiny"] .w-nav-button {
      display: block;
    }
  }
  
  .w-tabs {
    position: relative;
  }
  
  .w-tabs:before, .w-tabs:after {
    content: " ";
    grid-area: 1 / 1 / 2 / 2;
    display: table;
  }
  
  .w-tabs:after {
    clear: both;
  }
  
  .w-tab-menu {
    position: relative;
  }
  
  .w-tab-link {
    vertical-align: top;
    text-align: left;
    cursor: pointer;
    color: #222;
    background-color: #ddd;
    padding: 9px 30px;
    text-decoration: none;
    display: inline-block;
    position: relative;
  }
  
  .w-tab-link.w--current {
    background-color: #c8c8c8;
  }
  
  .w-tab-link:focus {
    outline: 0;
  }
  
  .w-tab-content {
    display: block;
    position: relative;
    overflow: hidden;
  }
  
  .w-tab-pane {
    display: none;
    position: relative;
  }
  
  .w--tab-active {
    display: block;
  }
  
  @media screen and (max-width: 479px) {
    .w-tab-link {
      display: block;
    }
  }
  
  .w-ix-emptyfix:after {
    content: "";
  }
  
  @keyframes spin {
    0% {
      transform: rotate(0);
    }
  
    100% {
      transform: rotate(360deg);
    }
  }
  
  .w-dyn-empty {
    background-color: #ddd;
    padding: 10px;
  }
  
  .w-dyn-hide, .w-dyn-bind-empty, .w-condition-invisible {
    display: none !important;
  }
  
  .wf-layout-layout {
    display: grid;
  }
  
  .w-layout-grid {
    grid-row-gap: 16px;
    grid-column-gap: 16px;
    grid-template-rows: auto auto;
    grid-template-columns: 1fr 1fr;
    grid-auto-columns: 1fr;
    display: grid;
  }
  
  .navbar3_container {
    width: 100%;
    height: 100%;
    grid-column-gap: 16px;
    grid-row-gap: 16px;
    grid-template-rows: auto;
    grid-template-columns: 1fr max-content 1fr;
    grid-auto-columns: 1fr;
    justify-content: space-between;
    align-items: center;
    justify-items: stretch;
    margin-left: auto;
    margin-right: auto;
    display: grid;
  }
  
  .button {
    color: rgba(0, 0, 0, 0);
    text-align: center;
    background-color: rgba(0, 0, 0, 0);
    border: 1px solid rgba(0, 0, 0, 0);
    padding: .75rem 1.5rem;
  }
  
  .button.is-navbar3-button {
    margin-left: 1rem;
    padding-top: .5rem;
    padding-bottom: .5rem;
  }
  
  .button.is-secondary {
    color: rgba(0, 0, 0, 0);
    background-color: rgba(0, 0, 0, 0);
  }
  
  .button.is-link {
    color: rgba(0, 0, 0, 0);
    background-color: rgba(0, 0, 0, 0);
    border-style: none;
    padding: .25rem 0;
    line-height: 1;
    text-decoration: none;
  }
  
  .button.is-link.is-icon {
    grid-column-gap: .5rem;
    grid-row-gap: .5rem;
  }
  
  .navbar3_tablet-menu-button {
    color: rgba(0, 0, 0, 0);
    background-color: #000;
    border: 1px solid rgba(0, 0, 0, 0);
    margin-left: 1rem;
    padding: .5rem 1.5rem;
    display: none;
  }
  
  .navbar3_menu-button {
    padding: 0;
  }
  
  .dropdown-chevron {
    width: 1rem;
    height: 1rem;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    display: flex;
  }
  
  .navbar3_logo-link-menu {
    padding-left: 0;
    display: none;
    max-width: 90px;
      max-height: 90px;
  }
  
  .navbar3_menu-dropdown {
    margin-left: 0;
    margin-right: 0;
  }
  
  .navbar3_dropdown-list.w--open {
    background-color: #fff;
    border: 1px solid #000;
    padding: 8px;
    position: absolute;
  }
  
  .navbar3_link {
    margin-left: 0;
    margin-right: 0;
    padding: .5rem 1rem;
  }
  
  .navbar3_link.w--current {
    color: rgba(0, 0, 0, 0);
  }
  
  .navbar3_logo-link {
    padding-left: 0;
    max-width: 90px;
      max-height: 90px;
  }
  
  .navbar3_menu-background {
    display: none;
    position: static;
  }
  
  .navbar3_dropdown-link {
    padding: .5rem 1rem;
  }
  
  .navbar3_dropdown-link.w--current {
    color: rgba(0, 0, 0, 0);
  }
  
  .navbar3_menu {
    justify-content: flex-start;
    align-items: center;
    margin-left: -1rem;
    display: flex;
    position: static;
  }
  
  .navbar3_dropdown-toggle {
    grid-column-gap: .5rem;
    align-items: center;
    padding: .5rem 1rem;
    display: flex;
  }
  
  .navbar3_component {
    width: 100%;
    min-height: 4.5rem;
    background-color: rgba(0, 0, 0, 0);
    border-bottom: 1px solid rgba(0, 0, 0, 0);
    align-items: center;
    padding-left: 5%;
    padding-right: 5%;
    display: flex;
  }
  
  .text-size-medium {
    font-size: 1.125rem;
  }
  
  .margin-bottom, .margin-bottom.margin-xxlarge, .margin-bottom.margin-small, .margin-bottom.margin-xsmall, .margin-bottom.margin-medium {
    margin-top: 0;
    margin-left: 0;
    margin-right: 0;
  }
  
  .header26_image {
    width: 100%;
    height: 100%;
  }
  
  .padding-section-large {
    padding-top: 7rem;
    padding-bottom: 7rem;
  }
  
  .margin-top, .margin-top.margin-medium, .margin-top.margin-xlarge {
    margin-bottom: 0;
    margin-left: 0;
    margin-right: 0;
  }
  
  .button-group {
    grid-column-gap: 1rem;
    grid-row-gap: 1rem;
    flex-wrap: wrap;
    align-items: center;
    display: flex;
  }
  
  .button-group.is-center {
    justify-content: center;
  }
  
  .header26_component {
    flex-direction: column;
    align-items: center;
    display: flex;
  }
  
  .padding-global {
    padding-left: 5%;
    padding-right: 5%;
  }
  
  .text-align-center {
    text-align: center;
  }
  
  .max-width-large {
    width: 100%;
    max-width: 48rem;
  }
  
  .container-large {
    width: 100%;
    max-width: 80rem;
    margin-left: auto;
    margin-right: auto;
  }
  
  .layout141_image {
    width: 100%;
    height: 100%;
  }
  
  .layout141_component {
    flex-direction: column;
    align-items: center;
    display: flex;
  }
  
  .icon-embed-xxsmall {
    width: 1rem;
    height: 1rem;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    display: flex;
  }
  
  .text-weight-semibold {
    font-weight: 600;
  }
  
  .layout192_component {
    grid-column-gap: 5rem;
    grid-row-gap: 4rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr;
    grid-auto-columns: 1fr;
    align-items: center;
    display: grid;
  }
  
  .layout192_image {
    width: 100%;
    height: 100%;
  }
  
  .section_cta25 {
    position: relative;
  }
  
  .container-small {
    width: 100%;
    max-width: 48rem;
    margin-left: auto;
    margin-right: auto;
  }
  
  .layout1_image {
    width: 100%;
    height: 100%;
  }
  
  .layout1_component {
    grid-column-gap: 5rem;
    grid-row-gap: 4rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr;
    grid-auto-columns: 1fr;
    align-items: center;
    display: grid;
  }
  
  .blog33_image {
    width: 100%;
    height: 100%;
    aspect-ratio: 3 / 2;
    object-fit: cover;
  }
  
  .blog33_text-divider {
    margin-left: .5rem;
    margin-right: .5rem;
  }
  
  .blog33_image-link {
    width: 100%;
    margin-bottom: 1.5rem;
  }
  
  .blog33_author-wrapper {
    align-items: center;
    margin-top: 1.5rem;
    display: flex;
  }
  
  .blog33_author-image-wrapper {
    margin-right: 1rem;
  }
  
  .heading-style-h5 {
    font-size: 1.5rem;
    font-weight: 700;
    line-height: 1.4;
  }
  
  .text-size-regular {
    font-size: 1rem;
  }
  
  .blog33_component {
    flex-direction: column;
    align-items: center;
  }
  
  .text-size-small {
    font-size: .875rem;
  }
  
  .blog33_list {
    grid-column-gap: 2rem;
    grid-row-gap: 4rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr 1fr;
    display: grid;
  }
  
  .blog33_category-link {
    margin-bottom: .5rem;
    margin-right: 1rem;
    font-size: .875rem;
    font-weight: 600;
    text-decoration: none;
  }
  
  .blog33_category-link.w--current {
    border-bottom: 2px solid #000;
  }
  
  .blog3_title-link {
    margin-bottom: .5rem;
    text-decoration: none;
    display: block;
  }
  
  .blog33_image-wrapper {
    width: 100%;
    overflow: hidden;
  }
  
  .blog33_date-wrapper {
    align-items: center;
    display: flex;
  }
  
  .blog33_author-image {
    width: 3rem;
    height: 3rem;
    min-height: 3rem;
    min-width: 3rem;
    object-fit: cover;
    border-radius: 100%;
  }
  
  .margin-vertical, .margin-vertical.margin-medium {
    margin-left: 0;
    margin-right: 0;
  }
  
  .testimonial1_logo {
    max-height: 3.5rem;
  }
  
  .testimonial1_component {
    text-align: center;
    flex-direction: column;
    align-items: center;
    display: flex;
  }
  
  .testimonial1_client-image-wrapper {
    margin-bottom: 1rem;
  }
  
  .testimonial1_client-image {
    width: 4rem;
    height: 4rem;
    min-height: 4rem;
    min-width: 4rem;
    object-fit: cover;
    border-radius: 100%;
  }
  
  .success-text {
    font-weight: 600;
  }
  
  .signup-form-wrapper {
    grid-column-gap: 1rem;
    grid-row-gap: 1rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr max-content;
    grid-auto-columns: 1fr;
    margin-bottom: 1rem;
    display: grid;
  }
  
  .cta8_form-block {
    max-width: 30rem;
    margin-bottom: 0;
  }
  
  .text-size-tiny {
    font-size: .75rem;
  }
  
  .cta8_content {
    flex: 1;
  }
  
  .cta8_component {
    grid-column-gap: 5rem;
    grid-row-gap: 2rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr max-content;
    grid-auto-columns: 1fr;
    justify-content: space-between;
    align-items: start;
    display: grid;
  }
  
  .form-input {
    height: auto;
    min-height: 2.75rem;
    color: rgba(0, 0, 0, 0);
    background-color: rgba(0, 0, 0, 0);
    border: 1px solid rgba(0, 0, 0, 0);
    margin-bottom: 0;
    padding: .5rem .75rem;
    font-size: 1rem;
    line-height: 1.6;
  }
  
  .form-input:focus {
    border-color: #000;
  }
  
  .form-input::-ms-input-placeholder {
    color: rgba(0, 0, 0, .6);
  }
  
  .form-input::placeholder {
    color: rgba(0, 0, 0, .6);
  }
  
  .error-message {
    margin-top: 1.5rem;
    padding: .875rem 1rem;
  }
  
  .error-text {
    color: #e23939;
  }
  
  .success-message {
    background-color: rgba(0, 0, 0, 0);
    padding: 1.5rem;
  }
  
  .footer1_credit-text {
    font-size: .875rem;
  }
  
  .padding-bottom, .padding-bottom.padding-xxlarge {
    padding-top: 0;
    padding-left: 0;
    padding-right: 0;
  }
  
  .footer1_left-wrapper {
    flex-direction: column;
    display: flex;
  }
  
  .padding-vertical, .padding-vertical.padding-xxlarge {
    padding-left: 0;
    padding-right: 0;
  }
  
  .icon-embed-xsmall {
    width: 1.5rem;
    height: 1.5rem;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    display: flex;
  }
  
  .footer1_social-link {
    grid-column-gap: .75rem;
    grid-row-gap: .75rem;
    align-items: center;
    padding-top: .5rem;
    padding-bottom: .5rem;
    font-size: .875rem;
    text-decoration: none;
    display: flex;
  }
  
  .footer1_form-block {
    max-width: 35rem;
    margin-bottom: 0;
  }
  
  .footer1_link {
    padding-top: .5rem;
    padding-bottom: .5rem;
    font-size: .875rem;
    text-decoration: none;
  }
  
  .footer1_bottom-wrapper {
    justify-content: space-between;
    align-items: center;
    display: flex;
  }
  
  .footer1_link-list {
    flex-direction: column;
    grid-template-rows: auto;
    grid-template-columns: 100%;
    grid-auto-columns: 100%;
    align-items: flex-start;
    justify-items: start;
    display: flex;
  }
  
  .footer1_form {
    grid-column-gap: 16px;
    grid-row-gap: 16px;
    grid-template-rows: auto;
    grid-template-columns: 1fr max-content;
    grid-auto-columns: 1fr;
    margin-bottom: .75rem;
    display: grid;
  }
  
  .footer1_legal-list {
    grid-column-gap: 1.5rem;
    grid-row-gap: 0rem;
    white-space: normal;
    grid-template-rows: auto;
    grid-template-columns: max-content;
    grid-auto-columns: max-content;
    grid-auto-flow: column;
    justify-content: center;
    display: grid;
  }
  
  .footer1_menu-wrapper {
    grid-column-gap: 2rem;
    grid-row-gap: 1rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr 1fr;
    align-items: start;
  }
  
  .footer1_logo-link {
    padding-left: 0;
  }
  
  .footer1_legal-link {
    font-size: .875rem;
    text-decoration: underline;
  }
  
  .footer1_top-wrapper {
    grid-column-gap: 8vw;
    grid-row-gap: 1rem;
    grid-template-rows: auto;
    grid-template-columns: .75fr 1fr;
    align-items: start;
  }
  
  .line-divider {
    width: 100%;
    height: 1px;
    background-color: rgba(0, 0, 0, 0);
  }
  
  .padding-top, .padding-top.padding-medium {
    padding-bottom: 0;
    padding-left: 0;
    padding-right: 0;
  }
  
  .gallery7_lightbox-link {
    width: 100%;
  }
  
  .gallery7_image-wrapper-large {
    width: 100%;
    height: 100%;
    position: relative;
  }
  
  .gallery7_image3 {
    width: 100%;
    height: 100%;
    aspect-ratio: 16 / 9;
    object-fit: cover;
  }
  
  .gallery7_component {
    grid-column-gap: 2rem;
    grid-row-gap: 2rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr;
  }
  
  .gallery7_image2 {
    width: 100%;
    height: 100%;
    aspect-ratio: 16 / 9;
    object-fit: cover;
  }
  
  .gallery7_image1 {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }
  
  .gallery7_row {
    grid-column-gap: 2rem;
    grid-row-gap: 2rem;
    grid-template-rows: auto auto;
    grid-template-columns: 1fr 1fr;
    grid-auto-columns: 1fr;
    justify-items: center;
    display: grid;
  }
  
  .gallery7_image-wrapper {
    width: 100%;
    position: relative;
  }
  
  .layout250_image {
    width: 100%;
    height: 100%;
  }
  
  .home4-features_image-wrapper {
    width: 100%;
    position: relative;
  }
  
  .layout250_list {
    grid-column-gap: 3rem;
    grid-row-gap: 4rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr 1fr;
    grid-auto-columns: 1fr;
    align-items: start;
    justify-items: start;
    display: grid;
  }
  
  .layout250_component {
    flex-direction: column;
    align-items: flex-start;
    display: flex;
  }
  
  .layout250_item {
    width: 100%;
    flex-direction: column;
    align-items: center;
  }
  
  .header1_component {
    grid-column-gap: 5rem;
    grid-row-gap: 4rem;
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr;
    grid-auto-columns: 1fr;
    align-items: center;
    display: grid;
  }
  
  .header1_image {
    width: 100%;
    height: 100%;
  }
  
  @media screen and (max-width: 991px) {
    .navbar3_container {
      grid-auto-columns: 1fr;
      display: grid;
    }
  
    .navbar3_tablet-menu-button {
      width: 100%;
      margin-top: 1.5rem;
      margin-left: 0;
      margin-right: 0;
      display: inline-block;
    }
  
    .navbar3_menu-button {
      margin-left: -.5rem;
      padding: 0;
    }
  
    .navbar3_menu-button.w--open {
      background-color: rgba(0, 0, 0, 0);
    }
  
    .dropdown-chevron {
      top: auto;
      bottom: auto;
      left: auto;
      right: 0%;
    }
  
    .menu-icon3_line-bottom {
      width: 24px;
      height: 2px;
      background-color: #000;
      padding-bottom: 0;
      padding-right: 0;
    }
  
    .navbar3_logo-link-menu {
      float: none;
      margin-top: 2.5rem;
      margin-bottom: 2rem;
      display: flex;
      position: static;
      max-width: 90px;
      max-height: 90px;
    }
  
    .navbar3_menu-dropdown {
      flex-direction: column;
      justify-content: center;
      align-items: center;
      font-size: 1.125rem;
      display: block;
      position: relative;
    }
  
    .navbar3_dropdown-list {
      position: static;
      overflow: hidden;
    }
  
    .navbar3_dropdown-list.w--open {
      border-style: none;
      padding: 0;
      position: static;
    }
  
    .navbar3_link {
      padding: .75rem 0;
      font-size: 1.125rem;
      position: static;
    }
  
    .menu-icon3_line-middle {
      width: 24px;
      height: 2px;
      background-color: #000;
      justify-content: center;
      align-items: center;
      margin-top: 6px;
      margin-bottom: 6px;
      padding-bottom: 0;
      padding-right: 0;
      display: flex;
    }
  
    .navbar3_menu-background {
      z-index: 0;
      width: 100vw;
      height: 100vh;
      background-color: rgba(0, 0, 0, .5);
      padding-bottom: 0;
      padding-right: 0;
      display: none;
      position: absolute;
      top: 0%;
      bottom: 0%;
      left: 0%;
      right: 0%;
    }
  
    .menu-icon3_line-top {
      width: 24px;
      height: 2px;
      background-color: #000;
      padding-bottom: 0;
      padding-right: 0;
    }
  
    .navbar3_dropdown-link {
      padding: .75rem 0 .75rem 5%;
    }
  
    .navbar3_menu {
      z-index: 1;
      width: 80vw;
      height: 100dvh;
      -webkit-text-fill-color: inherit;
      background-color: rgba(0, 0, 0, 0);
      background-clip: border-box;
      border-right: 1px solid #000;
      flex-direction: column;
      justify-content: center;
      margin-left: 0;
      padding-bottom: 6.5rem;
      padding-left: 5vw;
      padding-right: 5vw;
      transition: height .5s;
      display: block;
      position: absolute;
      top: 0%;
      bottom: 0%;
      left: 0%;
      right: auto;
      overflow: auto;
    }
  
    .menu-icon3 {
      width: 48px;
      height: 48px;
      flex-direction: column;
      justify-content: center;
      align-items: center;
      margin-right: -.5px;
      padding-bottom: 0;
      padding-right: 0;
      display: flex;
    }
  
    .navbar3_dropdown-toggle {
      width: 100%;
      margin-left: 0;
      margin-right: 0;
      padding: .75rem 2rem .75rem 0;
      position: relative;
    }
  
    .margin-bottom {
      margin-top: 0;
      margin-left: 0;
      margin-right: 0;
    }
  
    .padding-section-large {
      padding-top: 6rem;
      padding-bottom: 6rem;
    }
  
    .margin-top {
      margin-bottom: 0;
      margin-left: 0;
      margin-right: 0;
    }
  
    .layout192_component, .layout1_component {
      min-height: auto;
      grid-column-gap: 3rem;
      grid-template-columns: 1fr 1fr;
      grid-auto-flow: row;
    }
  
    .blog33_list {
      grid-template-columns: 1fr 1fr;
    }
  
    .margin-vertical {
      margin-left: 0;
      margin-right: 0;
    }
  
    .cta8_content {
      margin-right: 0;
    }
  
    .cta8_component {
      grid-column-gap: 3rem;
      grid-row-gap: 2rem;
      grid-template-columns: 1fr;
    }
  
    .padding-bottom {
      padding-top: 0;
      padding-left: 0;
      padding-right: 0;
    }
  
    .padding-vertical {
      padding-left: 0;
      padding-right: 0;
    }
  
    .footer1_top-wrapper {
      grid-row-gap: 4rem;
      grid-template-columns: 1fr;
    }
  
    .padding-top {
      padding-bottom: 0;
      padding-left: 0;
      padding-right: 0;
    }
  
    .layout250_list {
      grid-column-gap: 2rem;
    }
  
    .header1_component {
      min-height: auto;
      grid-column-gap: 4rem;
      grid-row-gap: 4rem;
      grid-template-columns: 1fr;
      grid-auto-flow: row;
    }
  }
  
  @media screen and (max-width: 767px) {
    .button.is-navbar3-button {
      padding: .25rem 1rem;
    }
  
    .navbar3_menu {
      width: 90vw;
      padding-bottom: 5rem;
    }
  
    .navbar3_component {
      min-height: 4rem;
    }
  
    .text-size-medium {
      font-size: 1rem;
    }
  
    .margin-bottom {
      margin-top: 0;
      margin-left: 0;
      margin-right: 0;
    }
  
    .padding-section-large {
      padding-top: 4rem;
      padding-bottom: 4rem;
    }
  
    .margin-top {
      margin-bottom: 0;
      margin-left: 0;
      margin-right: 0;
    }
  
    .layout192_component, .layout1_component {
      grid-row-gap: 3rem;
      grid-template-columns: 1fr;
    }
  
    .heading-style-h5 {
      font-size: 1.25rem;
    }
  
    .blog33_list {
      grid-row-gap: 3rem;
      grid-template-columns: 1fr;
    }
  
    .margin-vertical {
      margin-left: 0;
      margin-right: 0;
    }
  
    .cta8_content {
      margin-right: 0;
    }
  
    .cta8_component {
      grid-column-gap: 1.5rem;
      grid-row-gap: 1.5rem;
      flex-direction: column;
      grid-template-columns: 1fr;
      justify-content: flex-start;
      align-items: flex-start;
    }
  
    .footer1_credit-text {
      margin-top: 1.5rem;
    }
  
    .padding-bottom {
      padding-top: 0;
      padding-left: 0;
      padding-right: 0;
    }
  
    .padding-vertical {
      padding-left: 0;
      padding-right: 0;
    }
  
    .footer1_bottom-wrapper {
      flex-direction: column-reverse;
      align-items: flex-start;
      padding-bottom: 1rem;
    }
  
    .footer1_legal-list {
      grid-column-gap: 0rem;
      grid-row-gap: 1rem;
      grid-auto-flow: row;
    }
  
    .footer1_menu-wrapper {
      grid-column-gap: 1.5rem;
    }
  
    .footer1_top-wrapper {
      grid-row-gap: 3rem;
    }
  
    .padding-top {
      padding-bottom: 0;
      padding-left: 0;
      padding-right: 0;
    }
  
    .gallery7_component, .gallery7_row {
      grid-column-gap: 1.5rem;
      grid-row-gap: 1.5rem;
      grid-template-columns: 1fr;
    }
  
    .layout250_list {
      grid-row-gap: 3rem;
      grid-template-columns: 1fr;
    }
  
    .header1_component {
      grid-column-gap: 3rem;
      grid-row-gap: 3rem;
    }
  }
  
  @media screen and (max-width: 479px) {
    .margin-bottom {
      margin-top: 0;
      margin-left: 0;
      margin-right: 0;
    }
  
    .margin-top {
      margin-bottom: 0;
      margin-left: 0;
      margin-right: 0;
    }
  
    .layout192_component, .layout1_component {
      grid-template-columns: 1fr;
    }
  
    .margin-vertical {
      margin-left: 0;
      margin-right: 0;
    }
  
    .signup-form-wrapper {
      grid-row-gap: .75rem;
      flex-direction: column;
      grid-template-columns: 1fr;
    }
  
    .padding-bottom {
      padding-top: 0;
      padding-left: 0;
      padding-right: 0;
    }
  
    .padding-vertical {
      padding-left: 0;
      padding-right: 0;
    }
  
    .footer1_form {
      grid-row-gap: 12px;
      flex-direction: column;
      grid-template-columns: 1fr;
    }
  
    .footer1_menu-wrapper {
      grid-row-gap: 2.5rem;
      grid-template-columns: 1fr;
    }
  
    .footer1_top-wrapper {
      grid-row-gap: 48px;
    }
  
    .padding-top {
      padding-bottom: 0;
      padding-left: 0;
      padding-right: 0;
    }
  
    .layout250_list, .header1_component {
      grid-template-columns: 1fr;
    }
  }
  
  #w-node-d5cc4488-8977-dc6d-d1fa-684790ada01d-33ac6a66 {
    justify-self: end;
  }
  
  #w-node-_753f700b-5ff1-b082-f445-5c3c2a503404-33ac6a66 {
    grid-area: span 2 / span 1 / span 2 / span 1;
  }
  
  #w-node-_753f700b-5ff1-b082-f445-5c3c2a503407-33ac6a66, #w-node-_753f700b-5ff1-b082-f445-5c3c2a50340a-33ac6a66 {
    grid-area: span 1 / span 1 / span 1 / span 1;
  }
  
  @media screen and (max-width: 767px) {
    #w-node-b4a61f81-4e83-d9a0-0bbc-a73604629929-33ac6a66 {
      order: -9999;
    }
  }
  .bn1 {
    display: inline-block;
    padding: 0.6em 1.7em;
    border: 0.1em solid #656363;
    margin: 0 0.3em 0.3em 0;
    border-radius: 0.12em;
    box-sizing: border-box  ;
    text-decoration: none;
    font-family: "Roboto", sans-serif;
    font-weight: 300;
    color: #ffffff;
    text-align: center;
    transition: all 0.2s;
    background-color: rgb(49, 48, 48);
    display: inline-block;
  }
  
  .bn1:hover {
    color: #000000;
    background-color: rgb(136, 135, 135);
  }
  .bn1:hover:after {
    left: auto;
    right: 0;
    width: 100%;
     position: absolute;
    content: "";
    width: 0;
    height: 100%;
    top: 0;
    left: 0;
    direction: rtl;
    z-index: -1;
    background: rgb(0, 0, 0);
    transition: all 0.3s ease;
  }
  /* Code by CodingTuting.Com */
html {
    scroll-behavior: smooth;
}

body {
    padding: 0;
    margin: 0;
}

section {
    text-align: justify;
    padding: 0 2em 2em;
}

h1 {
    text-align: center;
    font-family: roboto;
    font-weight: 400;
    font-size: 35px;
    color: #656565;
}

.dummy-text {
    color: #3c3b3b;
    font-family: lato;
    font-size: 20px;
    line-height: 1.5;
}

.col-6 {
    width:50%;
    display: inline-table;
}

footer {
    background-color: #3c3b3b;
    padding: 3em 4em 2em;
}

    footer .logo {
        color:#fff;
        font-size: 28px;
        font-family: roboto;
        max-width: 90px;
      max-height: 90px;
    }

    foote