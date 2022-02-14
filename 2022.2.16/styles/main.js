const selectVersion = document.getElementById('select-version');
const firstSegment = window.location.pathname.substring(1, window.location.pathname.indexOf('/', 1));
const secondSegment = window.location.pathname.substring(1, window.location.pathname.indexOf('/', 2));
var useFirstSegment = firstSegment.toLowerCase() !== 'everginedocs'? true : false;
selectVersion.value = useFirstSegment? firstSegment : secondSegment;

selectVersion.onchange = function() {
    const hostVersion = window.location.host;
    const pathVersion = window.location.pathname;
    let targetVersion = selectVersion.value;
    const segment = useFirstSegment? targetVersion : 'EvergineDocs' + '/' + targetVersion;

    // Generate page URL in other version
    var newAddress = '//' + hostVersion + '/' + segment + '/' +  pathVersion.substring(pathVersion.indexOf('/', 1) + 1);

    // Check if address exists
    function handleErrors(response) {
        if (!response.ok) {
            throw Error(response.statusText);
        }
        return response;
    }

    fetch(newAddress)
        .then(handleErrors)
        .then(response => window.location.href = newAddress )
        .catch(error => window.location.href = '//' + hostVersion + '/' + segment);
};

